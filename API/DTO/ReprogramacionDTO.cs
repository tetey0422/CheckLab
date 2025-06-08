namespace API.DTO
{
    public class ReprogramacionDTO
    {
        public int ReprogramacionID { get; set; }
        public int CitaID { get; set; }
        public DateTime FechaAnterior { get; set; }
        public DateTime FechaNueva { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
    }
}