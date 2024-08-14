namespace Product.Api.Endpoints.GetProducts
{
    public record GetProductsResponse(long Id, string Name, string CategoryName, string description, string price, string ImageName);
   
}
