using AutoMapper;
using Sell.Application.ViewModels.Product;
using Sell.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sell.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile :Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
