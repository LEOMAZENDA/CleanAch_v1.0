using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O Nome é Obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome da categoria")]

        public string Name { get; set; }    
    }
}
