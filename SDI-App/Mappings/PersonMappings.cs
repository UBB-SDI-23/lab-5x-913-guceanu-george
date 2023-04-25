using AutoMapper;
using SDI_App.DTO.PersonDTOs;
using SDI_App.Models;

namespace SDI_App.Mappings
{
    public class PersonMappings : Profile
    {
        public PersonMappings()
        {

            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();
            CreateMap<AddPersonDTO, Person>();
            CreateMap<Person, AddPersonDTO>();
            CreateMap<EditPersonDTO, Person>();
            CreateMap<PersonInClass, Person>();
            CreateMap<Person, PersonInClass>();
        }
    }
}