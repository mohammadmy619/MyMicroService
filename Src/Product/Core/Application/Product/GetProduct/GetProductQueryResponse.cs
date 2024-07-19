using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product
{
    public record GetProductQueryResponse(string Name, string CategoryName, string description, string price, string ImageName)
    {
        public static explicit operator GetProductQueryResponse(Domin.Entites.Product product) => 
            new GetProductQueryResponse(product.Name, 
                product.CategoryName,
                product.description,
                product.price.ToString()
                ,product.ImageName
                );
    }
}
