namespace API.DTO
{
    public class EnfermeroDTO
    {
        public int EnfermeroID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int UsuarioID { get; set; }
        public string Estado { get; set; }
    }
}