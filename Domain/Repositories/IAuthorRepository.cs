public interface IAuthorRepository
{
  Task<List<Author>> AllAuthors();
  Task<Author> GetAuthor(Guid id);
  Task<List<Author>> GetAuthorByName(string name);
  Task<List<Post>> PostsOfAuthor(Guid id);
  Task<Author> NewAuthor(IAuthorRequest ar);
}