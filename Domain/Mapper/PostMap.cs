using AutoMapper;

public class PostMap : Profile
{
  public PostMap()
  {
    CreateMap<Post, PostRequest>().ReverseMap();
  }
}