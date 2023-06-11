using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public sealed class Category : EntityBase
    {
        public string Name { get; private set; }
        public ICollection<Product> Products { get; set; }

        public Category( string name) {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Id Inválido");
            Id = id;
           ValidateDomain(name);
        }
        public void Update(string name) {
            ValidateDomain(name);
        }

        private void ValidateDomain (string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Nome Inválido.Este campo é obrigatorio");
            DomainExceptionValidation.When(name.Length < 3,
                "Nome Inválido.Este campo é obrigatorio");

            Name = name;
        }
    }
}
