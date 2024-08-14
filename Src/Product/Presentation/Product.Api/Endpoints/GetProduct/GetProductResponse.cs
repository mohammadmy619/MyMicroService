using Domain.Enums;

namespace Product.Api.Endpoints.GetProduct
{

   
    public record GetProductResponse(long Id,string Name, string CategoryName, string description, string price, string ImageName);

    
}
