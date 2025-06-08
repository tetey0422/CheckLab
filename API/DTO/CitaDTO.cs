namespace API.DTO
{
    public class CitaDTO
    {
        public int CitaID { get; set; }
        public int PacienteID { get; set; }
        public int ExamenID { get; set; }
        public DateTime FechaHora { get; set; }
        public int EstadoID { get; set; }
        public string Estado { get; set; }
        // Si quieres incluir listas de IDs relacionados:
        // public List<int> ReprogramacionIDs { get; set; }
        // public List<int> ResultadoIDs { get; set; }
        // public List<int> HistorialCitaIDs { get; set; }
    }
}