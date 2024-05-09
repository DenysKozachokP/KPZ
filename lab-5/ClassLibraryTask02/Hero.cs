namespace ClassLibraryTask02
{
    public abstract class Hero
    {
        public IInventory inventory;
        public void SetInventory(IInventory inventory)
        {
            this.inventory = inventory;
        }
        public abstract void Attack();
    }
}
