using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public string description { get; set; }
        public string CategoryName { get; set; }
        public decimal price { get; set; }
        public string ImageName { get; set; }
        public ProductStatus Status { get; set; }


    }
}
