public class PostRequest : IPostRequest
{
  public string Title { get; set; }
  public string Content { get; set; }
  public string Thumb { get; set; }
  public Guid AuthorId { get; set; }
}