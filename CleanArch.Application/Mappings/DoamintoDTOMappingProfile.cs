using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Mappings
{
    public class DoamintoDTOMappingProfile :Profile
    {
        public DoamintoDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
