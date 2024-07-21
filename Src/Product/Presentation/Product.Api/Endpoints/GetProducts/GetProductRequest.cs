namespace Product.Api.Endpoints.GetProducts
{
    public record GetProductRequest([FromRoute(Name = "ProductId")] string ProductId);
   
}
