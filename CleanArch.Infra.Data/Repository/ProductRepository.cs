using CleanArch.Domain.Entities;
using CleanArch.Domain.Inferfaces;
using CleanArch.Infra.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {

        ProjectDbContext _oroductContext;

        public ProductRepository(ProjectDbContext oroductContext)
        {
            _oroductContext = oroductContext;
        }

        public async Task<Product> CreateAsync(Product poroduct)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductCategoryAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product poroduct)
        {
            throw new NotImplementedException();
        }
    }
}
