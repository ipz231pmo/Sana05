using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Currency Cost { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public float Weight { get; set; }
        public Product(string name, int price, Currency cost, int quantity, string producer, float weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, int price, Currency cost, int quantity, float weight) 
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Weight = weight;
            Producer = String.Empty;
        }
        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }
        public Product()
        {
            Name = String.Empty;
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = String.Empty;
            Weight = 0;
        }
        public decimal GetPriceInUAH()
        {
            return Price*Cost.ExRate;
        }
        public decimal GetTotalPriceInUAH() 
        { 
            return Price*Cost.ExRate * Quantity;
        }
        public float GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
