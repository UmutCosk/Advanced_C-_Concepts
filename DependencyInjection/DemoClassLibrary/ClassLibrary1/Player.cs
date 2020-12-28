using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibraryDemo
{
    public class Player : IPlayer
    {
        IInventory _inventory;
       
        
        public Player(IInventory inventory)
        {
            _inventory = inventory;
        }

        public void CraftItem()
        {
            _inventory.AddItem("Sword of Humain", 1);

        }
        public void LookIntoBank()
        {
            _inventory.LoadItemsInBank();
        }
    }
}
