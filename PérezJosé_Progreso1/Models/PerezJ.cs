using System.ComponentModel.DataAnnotations;

namespace PérezJosé_Progreso1.Models
{
    public class PerezJ
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 100)]
        public int AtributoInt { get; set; }

        [Required]
        [Range(0.1, 10000.0)]
        public decimal AtributoDecimal { get; set; }

        [Required]
        [StringLength(100)]
        public string AtributoString { get; set; }

        public bool AtributoBool { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public Celular Celular { get; set; }
    }
}

