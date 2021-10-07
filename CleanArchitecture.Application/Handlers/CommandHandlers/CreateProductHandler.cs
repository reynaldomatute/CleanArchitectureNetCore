using CleanArchitectura.Core.Entities;
using CleanArchitectura.Core.Repositories;
using CleanArchitecture.Application.Commands;
using CleanArchitecture.Application.Mappers;
using CleanArchitecture.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Handlers.CommandHandlers
{
    public class CreateProductHandler: IRequestHandler<CreateProductCommand, ProductResponse>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var productEntity = ProductMapper.Mapper.Map<Product>(request);
            if (productEntity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            var newProduct = await _productRepository.AddAsync(productEntity);
            var productResponse = ProductMapper.Mapper.Map<ProductResponse>(newProduct);
            return productResponse;
        }
    }
}
    