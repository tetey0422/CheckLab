namespace API.DTO
{
    public class LogSistemaDTO
    {
        public int LogID { get; set; }
        public int UsuarioID { get; set; }
        public string Accion { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
    }
}