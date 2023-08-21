public interface IPostRequest
{
  string Title { get; set; }
  string Content { get; set; }
  string Thumb { get; set; }
  Guid AuthorId { get; set; }
}