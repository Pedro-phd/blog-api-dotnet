using AutoMapper;

public class AuthorMap : Profile
{
  public AuthorMap()
  {
    CreateMap<Author, AuthorRequest>().ReverseMap();
  }
}