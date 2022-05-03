using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarShop.Models
{
    public class Cart
    {
        public static List<Product> products = new List<Product>(); 
        
        public static List<Product> GetProducts()
        {
            return products;
        }

        public static void SetProducts(List<Product> products)
        {
            Cart.products = products;
        }

        public static decimal TotalPrice()
        {
            decimal total = 0;
            for (int i=0; i < products.Count; ++i)
            {
                total += products[i].DiscountPrice;
            }
            return total;
        }

        public static decimal TotalWithoutDiscount()
        {
            decimal total = 0;
            for(int i = 0; i < products.Count; ++i)
            {
                total += products[i].Price;
            }
            return total;
        }

    }
}
