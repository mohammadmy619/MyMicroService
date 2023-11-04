using Domin.Common;
using Domin.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entites
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string description { get; set; }
        public string CategoryName { get; set; }
        public string price { get; set; }
        public string ImageName { get; set; }
        public ProductStatus Status { get; set; }


    }
}
