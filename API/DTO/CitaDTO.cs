namespace API.DTO
{
    public class CitaDTO
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