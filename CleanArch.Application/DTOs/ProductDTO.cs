using CleanArch.Domain.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome do Producto")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "A Descrição é Obrigatório")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("Descrição")]
        public string Description { get; private set; }

        [Required(ErrorMessage = "O Preço é Obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "0:C2")]//
        [DataType(DataType.Currency)]
        [DisplayName("Preço")]
        public decimal Price { get; private set; }

        [Required(ErrorMessage = "O Estqoue é Obrigatório")]
        [DisplayName("Estqoue")]
        [Range(1,9999)]
        public int Stock { get; private set; }

        [MaxLength(250)]
        [DisplayName("Imagem do Producto")]
        public string Image { get; private set; }

        public Category Category { get; set; }
        [DisplayName("Categorias")]
        public int CategoryId { get; set; }

    }
}
