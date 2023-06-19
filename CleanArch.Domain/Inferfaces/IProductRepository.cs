using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Inferfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int? id);
        //Task<Product> GetProductCategoryAsync(int? id);
        Task<Product> CreateAsync(Product poroduct);
        Task<Product> UpdateAsync(Product poroduct);
        Task<Product> DeleteAsync(Product poroduct);
    }
}
