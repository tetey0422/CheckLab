using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Afiliacion
    {
        [Key]
        public int AfiliacionID { get; set; }

        [Required]
        [MaxLength(10)]
        public string TipoDocumento { get; set; }

        [Required]
        [MaxLength(20)]
        public string Documento { get; set; }

        [ForeignKey("EPS")]
        public int EPSID { get; set; }
        public EPS EPS { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}