using CleanArch.Application.Produts.Commands;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Inferfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Application.Produts.Hendlers
{
    public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public ProductCreateCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> Handle(ProductCreateCommand request,
           CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Description, request.Price,
                              request.Stock, request.Image);

            if (product == null)
            {
                throw new ApplicationException($"Erro ao criar Producto.");
            }
            else
            {
                product.CategoryId = request.CategoryId;
                return await _productRepository.CreateAsync(product);
            }
        }
    }
}
