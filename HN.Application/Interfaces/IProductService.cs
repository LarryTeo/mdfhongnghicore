using HN.Application.ViewModels.Product;
using HN.Untilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HN.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);

    }
}
