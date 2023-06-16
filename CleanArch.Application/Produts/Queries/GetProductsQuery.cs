using CleanArch.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace CleanArch.Application.Produts.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {

    }
}
