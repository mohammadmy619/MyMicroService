namespace Product.Api.Endpoints.GetProducts
{

    public record GetProductsRequest(
        [FromQuery] int Page = 1,
        [FromQuery] int Size = 10,
        [FromQuery] string Title = "");

}
