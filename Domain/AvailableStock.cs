namespace Domain
{
    public class AvailableStock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
         public double SalePrice { get; set; }
         public Supplier Supplier { get; set; }

    }
}