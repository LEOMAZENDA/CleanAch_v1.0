using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public sealed class Product : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DmainExceptionValidate.When(id < 0, "O valor do Id é ivalido");
            ValidateDomain(name, description, price, stock, image);
        }

        public void Update(string name, string description, decimal price, int stock, string image, int categotyId)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categotyId;
        }


        public void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DmainExceptionValidate.When(string.IsNullOrEmpty(name),
                 "Nome Inválido. Este campo é obrigatorio");
            DmainExceptionValidate.When(name.Length < 3,
                "Nome Curto. Este campo deve conter no minimo 3 caracteres");
            DmainExceptionValidate.When(name.Length > 50,
              "Nome Comprido. Este campo deve conter no máximo 50 caracteres");

            DmainExceptionValidate.When(string.IsNullOrEmpty(description),
                "Descrição Inválido.Este campo é obrigatorio");

            DmainExceptionValidate.When(price < 0,
                            "Preço Inválido. Este campo não deve ser menor que zero (0)");

             DmainExceptionValidate.When(stock < 0,
                            "Estoque Inválido. Este campo não deve ser menor que zero (0)");

            DmainExceptionValidate.When(image.Length > 250,
                "Nome Inválido. Este campo o seu valor máximo é de 250 caracteres");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
    }
}
