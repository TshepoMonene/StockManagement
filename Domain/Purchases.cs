namespace Domain
{
    public class Purchases
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
        public int PurchasedBy { get; set; }
        public DateTime PurchasedOn { get; set; }



        
    }
}