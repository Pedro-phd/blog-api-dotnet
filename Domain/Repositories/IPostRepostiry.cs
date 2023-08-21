public interface IPostRepository
{
  Task<List<Post>> AllPosts();
  Task<Post> Get(Guid id);
  Task<Post> NewPost(IPostRequest pr);

  Task<List<Post>> Search(string t);
}