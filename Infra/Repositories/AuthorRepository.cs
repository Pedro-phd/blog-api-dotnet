using AutoMapper;
using Microsoft.EntityFrameworkCore;

public class AuthorRepository : IAuthorRepository
{
  private readonly DataBaseContext _context;
  private readonly IMapper _mapper;

  public AuthorRepository(DataBaseContext context, IMapper mapper)
  {
    _context = context;
    _mapper = mapper;
  }

  public async Task<List<Author>> AllAuthors()
  {
    return await _context.Authors.AsNoTracking().ToListAsync();
  }

  public async Task<Author> GetAuthor(Guid id)
  {
    return await _context.Authors.Where(a => a.Id == id).FirstOrDefaultAsync();
  }

  public async Task<List<Author>> GetAuthorByName(string name)
  {
    return await _context.Authors.FromSqlRaw("SELECT * FROM authors WHERE similarity(name, {0}) > 0 ORDER BY similarity(name, {0}) DESC", name)
        .ToListAsync();
  }

  public async Task<Author> NewAuthor(IAuthorRequest ar)
  {
    try
    {
      var Author = _mapper.Map<Author>(ar);
      await _context.Authors.AddAsync(Author);
      await _context.SaveChangesAsync();
      return Author;

    }
    catch (System.Exception err)
    {
      Console.WriteLine(err.Message);
      if (err.InnerException != null)
      {
        Console.WriteLine(err.InnerException.Message);
        throw new Exception(err.InnerException.Message);
      };
      throw new Exception(err.Message);
    }
  }

  public async Task<List<Post>> PostsOfAuthor(Guid id)
  {
    return await _context.Posts.Where(a => a.AuthorId == id).AsNoTracking().ToListAsync();
  }
}