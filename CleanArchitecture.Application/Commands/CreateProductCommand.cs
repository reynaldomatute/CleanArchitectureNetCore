using CleanArchitecture.Application.Responses;
using MediatR;

namespace CleanArchitecture.Application.Commands
{
    public class CreateProductCommand : IRequest <ProductResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BatchPrice { get; set; }
        public string Brand { get; set; }
    }
}
