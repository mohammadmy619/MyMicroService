using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.GetProducts
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IReadOnlyCollection<GetProductsQueryResponse>>
    {
        private readonly IProductRepository _ProductRepository;

        public GetProductsHandler(IProductRepository ProductRepository)
        {
                _ProductRepository=ProductRepository;
        }

        public async Task<IReadOnlyCollection<GetProductsQueryResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var GetProducts = await _ProductRepository.GetQuery()
                                .Where(x => x.Status == Domain.Enums.ProductStatus.Active)
                                .Where(x => x.Name.Contains(request.Title))
                                .OrderByDescending(x => x.CreatedDate)
                                .Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize)
                                .ToListAsync(cancellationToken);

            return [.. GetProducts.Select(x => (GetProductsQueryResponse) x)];
           
        }
    }
}
