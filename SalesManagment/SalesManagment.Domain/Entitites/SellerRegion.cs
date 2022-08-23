using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagment.Domain.Entitites
{
    public class SellerRegion
    {
        [Key]
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int Region { get; set; }
        public bool Status {get;set;}

        public virtual Seller? Seller { get; set; } 
    }
}
