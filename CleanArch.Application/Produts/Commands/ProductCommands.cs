using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Produts.Commands
{
    public abstract class ProductCommands : IRequest<Product>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; set; }
    }
}
