using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Cita
    {
        [Key]
        public int CitaID { get; set; }

        [ForeignKey("Paciente")]
        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; }

        [ForeignKey("Examen")]
        public int ExamenID { get; set; }
        public Examen Examen { get; set; }

        public DateTime FechaHora { get; set; }

        [ForeignKey("EstadoCita")]
        public int EstadoID { get; set; }
        public EstadoCita EstadoCita { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }

        public ICollection<Reprogramacion> Reprogramaciones { get; set; }
        public ICollection<Resultado> Resultados { get; set; }
        public ICollection<HistorialCita> Historiales { get; set; }
    }
}