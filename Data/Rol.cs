using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}