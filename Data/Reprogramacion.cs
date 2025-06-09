using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Reprogramacion
    {
        [Key]
        public int ReprogramacionID { get; set; }

        [ForeignKey("Cita")]
        public int CitaID { get; set; }
        public Cita Cita { get; set; }

        public DateTime NuevaFecha { get; set; }

        public string Motivo { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}