using AutoMapper;
using HN.Application.ViewModels.Product;
using HN.Application.ViewModels.System;
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
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
        }
    }
}
