using AutoMapper;
using Microsoft.EntityFrameworkCore;
public class PostRepository : IPostRepository
{
  private readonly DataBaseContext _context;
  private readonly IMapper _mapper;

  public PostRepository(DataBaseContext context, IMapper mapper)
  {
    _context = context;
    _mapper = mapper;
  }

  public async Task<List<Post>> AllPosts()
  {
    return await _context.Posts.AsNoTracking().ToListAsync();
  }

  public async Task<Post> Get(Guid id)
  {
    return await _context.Posts.Where(p => p.Id == id).FirstOrDefaultAsync();
  }

  public async Task<List<Post>> Search(string term)
  {
    return await _context.Posts.FromSqlRaw("SELECT * FROM posts WHERE similarity(title, {0}) > 0 ORDER BY similarity(title, {0}) DESC", term)
        .ToListAsync();
  }

  public async Task<Post> NewPost(IPostRequest pr)
  {
    try
    {
      var Post = _mapper.Map<Post>(pr);
      await _context.Posts.AddAsync(Post);
      await _context.SaveChangesAsync();
      return Post;
    }
    catch (Exception err)
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
}