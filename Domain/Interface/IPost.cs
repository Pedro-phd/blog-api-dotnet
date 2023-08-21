public interface IPost
{
  Guid Id { get; }
  Guid AuthorId { get; set; }
  string Title { get; set; }
  string Slug { get; set; }
  string Content { get; set; }
  string Thumb { get; set; }
}