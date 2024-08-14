using Domain.Enums;
using Microsoft.EntityFrameworkCore;


namespace Application.Product.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, GetProductQueryResponse>
    {
        private readonly IProductRepository _Productrepository;
        public GetProductHandler(IProductRepository Productrepository)
        {
            _Productrepository = Productrepository;
        }

        public async Task<GetProductQueryResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {

            var GetProduct = await _Productrepository.GetQuery()
                .Where(s => s.IsDelete == false && s.Status == ProductStatus.Active && s.Id == request.Id).FirstOrDefaultAsync();

            if (GetProduct is null)
            {
                throw new NotFoundProductException();
            }

            return (GetProductQueryResponse)GetProduct;
        }
    }
}
