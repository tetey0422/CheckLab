namespace API.DTO
{
    public class HistorialCitaDTO
    {
        [Key]
        public int HistorialID { get; set; }

        [ForeignKey("Cita")]
        public int CitaID { get; set; }
        public Cita Cita { get; set; }

        public int EstadoAnterior { get; set; }

        public int EstadoNuevo { get; set; }

        public DateTime FechaCambio { get; set; }
    }
}