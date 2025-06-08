namespace API.DTO
{
    public class ResultadoDTO
    {
        public int ResultadoID { get; set; }
        public int CitaID { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}