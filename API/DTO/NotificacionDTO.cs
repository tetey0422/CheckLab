namespace API.DTO
{
    public class NotificacionDTO
    {
        public int NotificacionID { get; set; }
        public int UsuarioID { get; set; }
        public string Mensaje { get; set; }
        public bool Leida { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}