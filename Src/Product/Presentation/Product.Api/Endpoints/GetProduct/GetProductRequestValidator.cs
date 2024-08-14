namespace Product.Api.Endpoints.GetProduct
{
    public class GetProductRequestValidator : AbstractValidator<GetProductRequest>
    {
        public GetProductRequestValidator()
        {
            RuleFor(x => x.ProductId)
                .NotEmpty()
                .NotNull();
        }
    }
}
