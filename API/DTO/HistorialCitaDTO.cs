namespace API.DTO
{
    public class HistorialCitaDTO
    {
        public int HistorialID { get; set; }
        public int CitaID { get; set; }
        public int EstadoAnterior { get; set; }
        public int EstadoNuevo { get; set; }
        public DateTime FechaCambio { get; set; }
    }
}