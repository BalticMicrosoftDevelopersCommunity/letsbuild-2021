using AutoMapper;
using WebReg.Data.Models;
using WebReg.Models;

namespace WebReg.Automapper
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonViewModel>()
                .ForMember(dest => dest.BirthDate,
                           opt => opt.MapFrom(src => src.BirthDate.HasValue ? src.BirthDate.Value.ToString("d") : string.Empty));
            CreateMap<AddPersonViewModel, Person>();
        }
    }
}
