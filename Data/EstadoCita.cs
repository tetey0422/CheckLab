using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data{
    public class EstadoCita
    {
        [Key]
        public int EstadoID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Descripcion { get; set; }

        public ICollection<Cita> Citas { get; set; }
    }
}