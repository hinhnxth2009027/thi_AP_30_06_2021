using System;

namespace thi_AP
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(){}

        public Product(string productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ProductId} \t {ProductName} \t ${Price}";
        }
    }
}