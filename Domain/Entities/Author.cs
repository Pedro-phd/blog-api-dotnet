using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("authors")]
[PrimaryKey("Id")]
public class Author : IAuthor
{

  public Author(string name, string email)
  {
    Id = Guid.NewGuid();
    Name = name;
    Email = email;
  }
  [Key]
  [Column("id")]
  public Guid Id { get; }
  [Column("name")]
  public string Name { get; set; }
  [Column("email")]
  public string Email { get; set; }


}