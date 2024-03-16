using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT_MANAGEMENT.Models
{
    internal class PrintModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public float Price { get; set; }
        public PrintModel(int id, string name, int quantity, float price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
