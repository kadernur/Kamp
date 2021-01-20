using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{ //Ürünle ilgili operasyonları inceler.

    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi. ");
            
            
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi. ");
        }




    }
}
