using Application.Product;
using Application.Product.GetProduct;

namespace Product.Api.Endpoints.GetProduct
{
    public class GetProductMappingProfile : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<GetProductRequest, GetProductQuery>()
                       .Map(x => x.Id, src => src.ProductId);


            config.ForType<GetProductResponse, GetProductQueryResponse>()
                       .Map(x => x.Id, src => src.Id)
                       .Map(x => x.CategoryName, src => src.CategoryName)
                       .Map(x => x.Name, src => src.Name)
                       .Map(x => x.description, src => src.description)
                       .Map(x => x.price, src => src.price)
                       .Map(x => x.ImageName, src => src.ImageName);

        }
    }
}
