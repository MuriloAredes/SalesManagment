
using System.ComponentModel.DataAnnotations;

namespace SalesManagment.Domain.Entitites
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Cep { get; set; } = String.Empty;
        public string Adress { get; set; } = String.Empty;
        public string Number { get; set; } = String.Empty;
        public string Complement { get; set; } = String.Empty;


        public virtual SellerRegion? SellerRegions { get; set; }

        public virtual List<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
