using AutoMapper;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{

  private readonly IMapper _mapper;
  private readonly IPostRepository _postRepository;

  public PostController(IMapper mapper, IPostRepository postRepository)
  {
    _mapper = mapper;
    _postRepository = postRepository;
  }

  [HttpGet("/post/all")]
  public async Task<IActionResult> AllPostsAsync()
  {

    return Ok(await _postRepository.AllPosts());
  }

  [HttpGet("/post/{id}")]
  public async Task<IActionResult> GetUnique(Guid id)
  {
    return Ok(await _postRepository.Get(id));
  }

  [HttpGet("/post/search")]
  public async Task<IActionResult> Search(string t)
  {
    return Ok(await _postRepository.Search(t));
  }

  [HttpPost("/post/new")]
  public async Task<IActionResult> NewPostAsync(PostRequest pr)
  {
    var Post = _mapper.Map<Post>(pr);
    try
    {
      await _postRepository.NewPost(pr);
      return Ok(Post);

    }
    catch (System.Exception err)
    {
      return BadRequest(err.Message);
      throw;
    }
  }
}