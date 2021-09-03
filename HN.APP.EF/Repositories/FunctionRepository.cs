using HN.Data.Entities;
using HN.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HN.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
