using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SDI_App.DTO.AwDTOs;
using SDI_App.Models;

namespace SDI_App.Mappings
{
    public class AwMappings : Profile
    {
        public AwMappings()
        {
            CreateMap<AwShortDTO, AccessedWebsite>();
            CreateMap<AccessedWebsite, AwShortDTO>();
            CreateMap<AwDTO, AccessedWebsite>();
            CreateMap<AccessedWebsite, AwDTO>();
        }
    }
}