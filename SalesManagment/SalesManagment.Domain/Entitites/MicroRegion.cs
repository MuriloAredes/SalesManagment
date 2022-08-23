using System.ComponentModel.DataAnnotations;

namespace SalesManagment.Domain.Entitites
{
    public class MicroRegion
    {
        [Key]
        public int Id { get; set; }
       
        public string Sigla { get; set; } = String.Empty;
        
        public string Nome { get; set; } = String.Empty;
        public int RegionId { get; set; }

        public virtual Region? Region { get; set; }
    }
}
