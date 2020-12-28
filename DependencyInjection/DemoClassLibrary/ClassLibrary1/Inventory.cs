using GameLibraryDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibraryDemo
{
    public class Inventory : IInventory
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public Inventory(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void AddItem(string item, int amount)
        {
            _logger.Log($"Adding {item} x{amount} times");
            _dataAccess.SaveData();


        }
        public void DropItem(string item, int amount)
        {
            _logger.Log($"Dropping {item} x{amount} times");
            _dataAccess.SaveData();
        }

        public void LoadItemsInBank()
        {
            _logger.Log("Loading items for bank access...");
            _dataAccess.LoadData();
        }
    }
}
