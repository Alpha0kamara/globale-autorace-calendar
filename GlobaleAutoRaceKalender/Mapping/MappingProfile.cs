using AutoMapper;
using GlobaleAutoRaceKalender.DTO;
using GlobaleAutoRaceKalender.Models;

namespace GlobaleAutoRaceKalender.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<Pilot, PilotAddDTO>().ReverseMap();
            CreateMap<Circuit, CircuitAddDTO>().ReverseMap();
            CreateMap<Race, RaceAddDTO>().ReverseMap();
        }
    }
}
