namespace Product.Api.Endpoints.GetProducts
{
    public record GetProductRequest([FromRoute(Name = "Product-id")] string ProductId);
   
}
