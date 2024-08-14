namespace Product.Api.Endpoints.GetProduct
{
    public record GetProductRequest([FromRoute(Name = "ProductId")] string ProductId);
   
}
