using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.GetProduct
{
    public record GetProductQuery(long Id) : IRequest<GetProductQueryResponse>
    {
    }
}
