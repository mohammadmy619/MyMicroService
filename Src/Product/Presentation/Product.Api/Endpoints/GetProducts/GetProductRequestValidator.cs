namespace Product.Api.Endpoints.GetProducts
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
