using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data{
    public class HistorialCita
    {
        [Key]
        public int HistorialID { get; set; }

        [ForeignKey("Cita")]
        public int CitaID { get; set; }
        public Cita Cita { get; set; }

        public int EstadoAnterior { get; set; }

        public int EstadoNuevo { get; set; }

        public DateTime FechaCambio { get; set; }
    }
}