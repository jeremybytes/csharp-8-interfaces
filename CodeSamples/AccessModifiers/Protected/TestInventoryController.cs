using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Protected
{
    public class TestInventoryController : IInventoryController
    {
        public void PushInventoryItem(InventoryItem item)
        {
            throw new NotImplementedException();
        }

        InventoryItem IInventoryController.PullInventoryItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
