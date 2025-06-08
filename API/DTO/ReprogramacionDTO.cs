namespace API.DTO
{
    public class ReprogramacionDTO
    {
        [Key]
        public int ReprogramacionID { get; set; }

        [ForeignKey("Cita")]
        public int CitaID { get; set; }
        public Cita Cita { get; set; }

        public DateTime NuevaFecha { get; set; }

        public string Motivo { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}