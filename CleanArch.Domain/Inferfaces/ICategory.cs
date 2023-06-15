using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Inferfaces
{
    public interface ICategory
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int? id);

        Task<Category> Create(Category category);
        Task<Category> Update(Category category);
        Task<Category> Remove(Category category);
    }
}
