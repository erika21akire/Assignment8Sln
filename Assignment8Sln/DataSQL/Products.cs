using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8Sln.DataSQL
{
   public class Products
    {
        [PrimaryKey, AutoIncrement] public int ProductsId { get; set; }
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}
