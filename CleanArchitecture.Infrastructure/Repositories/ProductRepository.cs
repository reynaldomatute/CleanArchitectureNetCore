using CleanArchitectura.Core.Entities;
using CleanArchitectura.Core.Repositories;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CleanArchitectureCotext cleanArchitectureCotext) : base(cleanArchitectureCotext) { }
        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            return await _cleanArchitectureCotext.Products.Where(m => m.Name == name).ToListAsync();
        }
    }
}
