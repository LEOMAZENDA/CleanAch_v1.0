using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Inferfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _productRepository = productRepository ??
                throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var produtEntities = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(produtEntities);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var produtEntity = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(produtEntity);
        }

        public async Task<ProductDTO> GetProductCategory(int? id)
        {
            var produtEntity = await _productRepository.GetProductCategoryAsync(id);
            return _mapper.Map<ProductDTO>(produtEntity);
        }

        public async Task Add(ProductDTO productDTO)
        {
            var produtEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.CreateAsync(produtEntity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var produtEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.UpdateAsync(produtEntity);
        }

        public async Task Remove(int? id)
        {
            var produtEntity = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.DeleteAsync(produtEntity);
        }
    }
}