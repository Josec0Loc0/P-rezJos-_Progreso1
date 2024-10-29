using System.ComponentModel.DataAnnotations;

namespace PérezJosé_Progreso1.Models
{
    public class Celular
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Range(2000, 2025)]
        public int Año { get; set; }

        [Required]
        [Range(0.0, 2000.0)]
        public decimal Precio { get; set; }

        //Relacion PerezJ
        public int PerezJId { get; set; }
        public PerezJ PerezJ{ get; set; }
    }
}
