using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data{
    public class Resultado
    {
        [Key]
        public int ResultadoID { get; set; }

        [ForeignKey("Cita")]
        public int CitaID { get; set; }
        public Cita Cita { get; set; }

        [Required]
        public string ArchivoPDF { get; set; }

        public DateTime FechaSubida { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}