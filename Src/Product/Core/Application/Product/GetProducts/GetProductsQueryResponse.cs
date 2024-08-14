using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.GetProducts
{
    public record GetProductsQueryResponse(long Id, string Name, string CategoryName, string description, string price, string ImageName)
    {
        public static explicit operator GetProductsQueryResponse(Domain.Entites.Product product) =>
            new GetProductsQueryResponse(product.Id, product.Name,
                product.CategoryName,
                product.description,
                product.price.ToString()
                , product.ImageName
                );

    }
}


