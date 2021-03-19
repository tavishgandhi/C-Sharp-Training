using System;

namespace Day4A1Q2
{
    class MainFile
    {

        static void Main(string[] args)
        {
 
            Inventory inventory = new Inventory();
            inventory.AddProduct(1, 10, false, 1);
            inventory.AddProduct(2, 2, false, 10);
            inventory.UpdateProductQuantity(1, 20);
            inventory.Update(1, 10, true);
            inventory.showDetails();
        }

    }
}
