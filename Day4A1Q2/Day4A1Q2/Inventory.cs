using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A1Q2
{
    class Inventory
    {
        public IDictionary<Product, int> products;
        public int TotalInventoryValue;

        // Event subscriber
        InventoryWorker worker;

        public Inventory()
        {
            products = new Dictionary<Product, int>();
            TotalInventoryValue = 0;
            worker = new InventoryWorker();
            worker.UpdateInventory += Worker_UpdateInventory;
        }

        // Subscribing to UpdateInventory Event
        public void Update(int productId, int price, bool isDefective)
        {
            worker.DoWork(productId, price, isDefective);

        }
        // Event Handling 
        private void Worker_UpdateInventory(object sender, ProductDetailsEventArgs e)
        {
            int productId = e.ProductId;
            Product product = findProduct(productId);

            if (e.isDefective)
            {
                TotalInventoryValue -= (product.Price * products[product]);
                products.Remove(product);
                Console.WriteLine("Defective Item removed");
            }
                

            if(product.Price != e.Price)
            {
                TotalInventoryValue -= (product.Price * products[product]);
                TotalInventoryValue += (e.Price * products[product]);
                Console.WriteLine("Price Changed");
            }

        }

        private Product findProduct(int Id)
        {
            foreach(KeyValuePair<Product,int> product in products)
            {
                if (Id == product.Key.Id)
                    return product.Key;
                
            }
            return null;
        }

        public void AddProduct(int id, int price, bool isDefective, int numOfItems)
        {
            
            Product product = new Product(id, price, isDefective);
            products.Add(product, numOfItems);
            TotalInventoryValue += (price * numOfItems);
        }

        public void RemoveProduct(int id)
        {
            Product product = findProduct(id);
            TotalInventoryValue -= (product.Price * products[product]);
            products.Remove(product);
        }

        public void UpdateProductQuantity(int productId, int quantity)
        {
            Product product = findProduct(productId);
            TotalInventoryValue -= (product.Price * products[product]);
            products[product] = quantity;
            TotalInventoryValue += (product.Price * quantity);
        }

        public void showDetails()
        {
            Console.WriteLine("Inventory Total value = " + TotalInventoryValue);
            foreach(KeyValuePair<Product, int> product in products)
            {
                Console.WriteLine(product);
            }
        }

    }
}
