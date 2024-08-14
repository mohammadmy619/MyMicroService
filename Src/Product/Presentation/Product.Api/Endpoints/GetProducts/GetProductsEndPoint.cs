using Application.Product.GetProducts;
using Product.Api.Abstractions;
using Product.Api.Endpoints.GetProduct;

namespace Product.Api.Endpoints.GetProducts
{
    public class GetProductsEndPoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {

            app.MapGet("/GetProducts/", async ([AsParameters] GetProductsRequest request,
                IMapper mapper,
                MediatR.IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = mapper.Map<GetProductsQuery>(request);

                var result = await mediator.Send(command, cancellationToken);

                return mapper.Map<GetProductsResponse>(result);

            });
        }
    }
}
