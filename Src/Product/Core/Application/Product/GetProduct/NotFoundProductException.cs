using BuildingBlocks.Domain;


namespace Application.Product.GetProduct
{
    internal class NotFoundProductException : DomainException
    {
        private const string _message = "Product not found.";

        public NotFoundProductException() : base(_message)
        {

        }
    }

}
