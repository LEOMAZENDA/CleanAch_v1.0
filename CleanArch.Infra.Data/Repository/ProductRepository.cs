using CleanArch.Domain.Entities;
using CleanArch.Domain.Inferfaces;
using CleanArch.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class ProductRepository : IProduct
    {

       private ProjectDbContext _poroductContext;

        public ProductRepository(ProjectDbContext poroductContext)
        {
            _poroductContext = poroductContext;
        }
            

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _poroductContext.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await _poroductContext.Products.FindAsync(id);
        }

        public async Task<Product> GetProductCategoryAsync(int? id)
        {
            return await _poroductContext.Products.Include(c => c.Category)
                .SingleOrDefaultAsync(p => p.Id == id); 
            // esse Icclude é conhecido como carregamento adiantado ou eager loading
        }

        public async Task<Product> CreateAsync(Product poroduct)
        {
            _poroductContext.Add(poroduct);
            await _poroductContext.SaveChangesAsync();
            return poroduct;
        }

        public async Task<Product> UpdateAsync(Product poroduct)
        {
            _poroductContext.Update(poroduct);
            await _poroductContext.SaveChangesAsync();
            return poroduct;
        }

        public async Task<Product> DeleteAsync(Product poroduct)
        {
            _poroductContext.Remove(poroduct);
            await _poroductContext.SaveChangesAsync();
            return poroduct;
        }
       
    }
}
