using Application.Product.GetProducts;

namespace Product.Api.Endpoints.GetProducts
{
    public class GetProductsMappingProfile:IRegister
    {
       

        public void Register(TypeAdapterConfig config)
        {
            config.ForType<GetProductsRequest, GetProductsQuery>()
                   .Map(x => x.PageNumber, src => src.Page)
                   .Map(x => x.PageSize, src => src.Size)
                   .Map(x => x.Title, src => src.Title);


        }
    }
}
