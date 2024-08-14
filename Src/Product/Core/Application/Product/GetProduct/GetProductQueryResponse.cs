using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product
{
    public record GetProductQueryResponse(long Id,string Name, string CategoryName, string description, string price, string ImageName)
    {
        public static explicit operator GetProductQueryResponse(Domain.Entites.Product product) => 
            new GetProductQueryResponse(product.Id, product.Name, 
                product.CategoryName,
                product.description,
                product.price.ToString()
                ,product.ImageName
                );
    }
}
