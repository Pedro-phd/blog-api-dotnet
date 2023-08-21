using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
  private readonly IAuthorRepository _authorRepository;

  public AuthorController(IAuthorRepository authorRepository)
  {
    _authorRepository = authorRepository;
  }

  [HttpGet("/authors/all")]
  public async Task<IActionResult> GetAll()
  {
    return Ok(await _authorRepository.AllAuthors());
  }

  [HttpGet("/authors/{id}/posts")]
  public async Task<IActionResult> GetPosts(Guid id)
  {
    return Ok(await _authorRepository.PostsOfAuthor(id));
  }

  [HttpGet("/authors/search")]
  public async Task<IActionResult> GetByName(string name)
  {
    return Ok(await _authorRepository.GetAuthorByName(name));
  }

  [HttpPost("/author/new")]
  public async Task<IActionResult> NewAuthor(AuthorRequest ar)
  {
    return Ok(await _authorRepository.NewAuthor(ar));
  }
}