namespace API.DTO
{
    public class ResultadoDTO
    {
        [Key]
        public int ResultadoID { get; set; }

        [ForeignKey("Cita")]
        public int CitaID { get; set; }
        public Cita Cita { get; set; }

        [Required]
        public string ArchivoPDF { get; set; }

        public DateTime FechaSubida { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}