using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.GetProducts
{
    public record GetProductsQuery(int PageNumber = 1, int PageSize = 10, string Title = "") : IRequest<IReadOnlyCollection<GetProductsQueryResponse>>;
    
}
