namespace API.DTO
{
    public class ExamenDTO
    {
        [Key]
        public int ExamenID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Duracion { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }

        public ICollection<Cita> Citas { get; set; }
    }
}