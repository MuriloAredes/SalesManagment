using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagment.Domain.Entitites
{
    public class Attendance
    {
        
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int SellerId { get; set; }
        public DateTime Register { get; set; }    
        public virtual Seller? User { get; set; } 
        public virtual Company? Company { get; set; } 
    }
}
