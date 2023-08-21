using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Slugify;

[Table("posts")]
[PrimaryKey("Id")]
public class Post : IPost
{
  public Post(Guid authorId, string title, string content, string thumb)
  {
    SlugHelper slug = new SlugHelper();

    Id = Guid.NewGuid();
    AuthorId = authorId;
    Title = title;
    Slug = slug.GenerateSlug(title);
    Content = content;
    Thumb = thumb;
  }

  [Key]
  [Column("id")]
  public Guid Id { get; }
  [Column("authorid")]
  public Guid AuthorId { get; set; }
  [Column("title")]
  public string Title { get; set; }
  [Column("slug")]
  public string Slug { get; set; }
  [Column("content")]
  public string Content { get; set; }
  [Column("thumb")]
  public string Thumb { get; set; }


}