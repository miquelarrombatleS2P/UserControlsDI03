﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlProduct
{
    class Product
    {
        public string productID { get; set; }
        public string ProductModelID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double ListPrice { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{productID}/{ProductModelID}/{Name}/{Description}/{ListPrice}/{Size}/{Color}";
        }
    }
}
