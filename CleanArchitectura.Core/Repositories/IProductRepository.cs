using CleanArchitectura.Core.Entities;
using CleanArchitectura.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectura.Core.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductByName(string name);
    }
}
