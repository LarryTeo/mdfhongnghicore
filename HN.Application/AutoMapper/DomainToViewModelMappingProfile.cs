using AutoMapper;
using HN.Application.ViewModels.Product;
using HN.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HN.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
