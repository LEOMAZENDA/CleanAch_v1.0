using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Produts.Commands
{
    public class ProductRemoveCommand : IRequest<Product>
    {
        public int Id { get; set; }

        public ProductRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
