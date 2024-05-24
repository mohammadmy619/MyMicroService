using MassTransit.Mediator;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Product.Api.Abstractions;

namespace Product.Api.Endpoints.GetProducts
{
    public class GetProductEndPoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("/GetProduct/", async ([FromHeader] string name) =>
            {
             

                return "mmmmm";
            });
        }
    }
}
