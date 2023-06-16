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
    public class CategoryRepository : ICategoryRepository
    {
        private ProjectDbContext _categoryContext;
        public CategoryRepository(ProjectDbContext context)
        {
            _categoryContext = context;
        }

        public async Task<Category> Create(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _categoryContext.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int? id)
        {
            return await _categoryContext.Categories.FindAsync(id);
        }

        public async Task<Category> Remove(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Update(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }
    }
}
