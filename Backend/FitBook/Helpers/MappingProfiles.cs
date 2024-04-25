using AutoMapper;
using FitBook.Dtos;
using FitBook.Models;

namespace FitBook.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, ResponseUserDto>();
        CreateMap<CreateUserDto, User>();
        CreateMap<CreateExerciseDto, Exercise>();
        CreateMap<Exercise, RepsonseExerciseDto>();
        CreateMap<Exercise, ResponseUserDto>();
        CreateMap<WorkoutExerciseDto, WorkoutExercise>();
        CreateMap<WorkoutExercise, WorkoutExerciseDto>();
        CreateMap<CreateWorkoutDto, Workout>();
        CreateMap<Workout, ResponseWorkoutDto>();
    }
}