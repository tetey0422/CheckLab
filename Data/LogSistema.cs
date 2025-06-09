using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data{
    public class LogSistema
    {
        [Key]
        public int LogID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        public string Accion { get; set; }

        public DateTime FechaHora { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}