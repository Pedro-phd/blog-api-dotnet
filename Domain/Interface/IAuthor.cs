public interface IAuthor
{
  Guid Id { get; }
  string Name { get; set; }
  string Email { get; set; }
}