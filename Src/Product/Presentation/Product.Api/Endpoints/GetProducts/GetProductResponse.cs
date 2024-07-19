using Domin.Enums;

namespace Product.Api.Endpoints.GetProducts
{

   
    public record GetProductResponse(string Name, string CategoryName, string description, decimal price, string ImageName);

    
}
