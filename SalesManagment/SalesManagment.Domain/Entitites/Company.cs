
using System.ComponentModel.DataAnnotations;

namespace SalesManagment.Domain.Entitites
{
    public class Company
    {
 
        [Key]
        public int Id { get; set; }
        public string Cnpj { get; set; } = String.Empty;
        public string SocialReason { get; set; } = String.Empty;
        public string Uf { get; set; } = String.Empty;
        public string Situation { get; set; } = String.Empty;
        public string Description{ get; set; } = String.Empty;

        public virtual List<Attendance>? Attendances { get; set; } 

    }
}
