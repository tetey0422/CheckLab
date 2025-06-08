namespace API.DTO
{
    public class PacienteDTO
    {
        public int PacienteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime? Nacimiento { get; set; }
        public int UsuarioID { get; set; }
        public string Estado { get; set; }
    }
}