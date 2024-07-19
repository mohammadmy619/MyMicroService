using Domin.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, GetProductQueryResponse>
    {
        private readonly IProductRepository _Productrepository;
        public GetProductHandler(IProductRepository Productrepository)
        {
            _Productrepository= Productrepository;
        }

        public async Task<GetProductQueryResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var GetProduct =  _Productrepository.GetQuery().Where(s => s.IsDelete == false && s.Status = ProductStatus.Active && s.Id == request.Id)
        }
    }
}
