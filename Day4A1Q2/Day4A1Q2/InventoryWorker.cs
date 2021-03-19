using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A1Q2
{
    // Event publisher
    class InventoryWorker
    {
        public event EventHandler<ProductDetailsEventArgs> UpdateInventory;

        public void DoWork(int productId , int changedPrice, bool isDefective)
        {
            OnInventoryUpdate(productId, changedPrice, isDefective);
        }

        protected virtual void OnInventoryUpdate(int productId, int changedPrice, bool isDefective)
        {
            if (UpdateInventory is not null)
                UpdateInventory(this, new ProductDetailsEventArgs(productId, changedPrice, isDefective));
        }
        
    }
}
