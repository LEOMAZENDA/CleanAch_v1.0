using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Produts.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
