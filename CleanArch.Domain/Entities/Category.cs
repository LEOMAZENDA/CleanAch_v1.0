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
            DmainExceptionValidate.When(id < 0, "Id Inválido");
           ValidateDomain(name);
        }
        public void Update(string name) {
            ValidateDomain(name);
        }

        private void ValidateDomain (string name)
        {
            DmainExceptionValidate.When(string.IsNullOrEmpty(name),
                "Nome Inválido.Este campo é obrigatorio");

            DmainExceptionValidate.When(string.IsNullOrEmpty(name),
                "Nome Inválido.Este campo é obrigatorio");

            DmainExceptionValidate.When(string.IsNullOrEmpty(name),
                            "Nome Inválido.Este campo é obrigatorio");
        }
    }
}
