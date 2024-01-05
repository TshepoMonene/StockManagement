using System.Data.SqlTypes;

namespace Domain
{
    public class StockRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime ModifiedBy { get; set; }

    }
}