using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Produts.Commands
{
    public class ProductsRemuveCommand : IRequest<Product>
    {
        public int Id { get; set; }

        public ProductsRemuveCommand(int id)
        {
            Id = id;
        }
    }
}
