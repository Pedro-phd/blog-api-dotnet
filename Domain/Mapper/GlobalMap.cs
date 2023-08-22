using AutoMapper;

public class GlobalMapper : Profile
{
  public GlobalMapper()
  {
    CreateMap<Post, PostRequest>().ReverseMap();
    CreateMap<Author, AuthorRequest>().ReverseMap();
  }
}