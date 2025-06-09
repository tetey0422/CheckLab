using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data{
    public class Notificacion
    {
        [Key]
        public int NotificacionID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        public string Mensaje { get; set; }

        public bool Leida { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}