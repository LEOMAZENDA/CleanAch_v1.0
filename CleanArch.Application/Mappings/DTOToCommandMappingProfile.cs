using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Produts.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
                CreateMap<ProductDTO, ProductCreateCommand>();  
                CreateMap<ProductDTO, ProductUpdateCommand>();  
        }
    }
}
