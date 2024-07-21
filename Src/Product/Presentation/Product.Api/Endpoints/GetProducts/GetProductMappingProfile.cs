using Application.Product.GetProduct;

namespace Product.Api.Endpoints.GetProducts
{
    public class GetProductMappingProfile : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<GetProductRequest, GetProductQuery>()
                       .Map(x => x.Id, src => src.ProductId);

        }
    }
}
