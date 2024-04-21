using AutoMapper;
using FitBook.Dtos;
using FitBook.Models;

namespace FitBook.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, UserDto>();
    }
}