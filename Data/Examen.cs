using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Examen
    {
        [Key]
        public int ExamenID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Duracion { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }

        public ICollection<Cita> Citas { get; set; }
    }
}