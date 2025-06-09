using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Enfermero
    {
        [Key]
        public int EnfermeroID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(100)]
        public string Apellidos { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioFK { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}