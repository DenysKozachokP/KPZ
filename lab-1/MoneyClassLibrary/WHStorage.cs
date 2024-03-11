using System;

namespace MoneyClassLibrary
{
    public class WHStorage
    {
        public Product Product { get; private set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; private set; }

        public WHStorage(Product product, int quantity, DateTime lastDeliveryDate)
        {
            Product = product;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryDate;
        }
    }
}
