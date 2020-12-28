namespace GameLibraryDemo
{
    public interface IInventory
    {
        void AddItem(string item, int amount);
        void DropItem(string item, int amount);
        void LoadItemsInBank();
    }
}