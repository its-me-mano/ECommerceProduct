using AutoMapper;
using ECommerceProduct.Entities.Dto;
using ECommerceProduct.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProduct.Profiles
{
    public class Automapper : Profile
    {
        public Automapper()
        {
            CreateMap<Product, ProductDto>().ReverseMap();

        }
    }
}
