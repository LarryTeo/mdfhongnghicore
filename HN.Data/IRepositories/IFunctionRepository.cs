using HN.Data.Entities;
using HN.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HN.Data.IRepositories
{
    public interface IFunctionRepository : IRepository<Function, string>
    {
    }
}
