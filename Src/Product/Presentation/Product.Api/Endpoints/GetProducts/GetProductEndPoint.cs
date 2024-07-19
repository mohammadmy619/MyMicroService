using MapsterMapper;
using MassTransit.Mediator;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Product.Api.Abstractions;
using Product.Api.Filters;

namespace Product.Api.Endpoints.GetProducts
{
    public class GetProductEndPoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("/GetProduct/", async([AsParameters] GetProductRequest request,
            IMapper mapper,
                MediatR.IMediator mediator,
                CancellationToken cancellationToken ) =>
            {
             

                return "mmmmm";
            }).Validator<GetProductRequestValidator>();
        }
    }
}
