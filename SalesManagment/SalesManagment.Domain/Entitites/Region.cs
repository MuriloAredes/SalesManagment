using System.ComponentModel.DataAnnotations;

namespace SalesManagment.Domain.Entitites
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
              
        public string Sigla { get; set; } = String.Empty;
       
        public string Nome { get; set; } = String.Empty;

        public virtual List<MicroRegion> MicroRegions { get; set; } = new List<MicroRegion>();
    }
}
