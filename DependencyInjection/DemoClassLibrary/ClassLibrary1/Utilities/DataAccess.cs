
using System;

namespace GameLibraryDemo.Utilities
{
    public class DataAccess : IDataAccess
    {
        ILogger _logger;
        public DataAccess(ILogger logger)
        {
            _logger = logger;
        }
        public void SaveData()
        {
            Console.WriteLine("Saving data...");
            _logger.Log("Data have been saved.");
            
            
        }

        public void LoadData()
        {
            Console.WriteLine("Loading data...");
            _logger.Log("Data have been loaded.");
        }
    }
}
