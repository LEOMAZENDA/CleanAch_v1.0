using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Inferfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int? id);

        Task<Category> Create(Category oroduct);
        Task<Category> Update(Category oroduct);
        Task<Category> Delete(int? id);
    }
}
