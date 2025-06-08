namespace API.DTO
{
    public class UsuarioDTO
    {
        public int UsuarioID { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        // No exponer contraseña
        public int RolID { get; set; }
        public string Estado { get; set; }
        // Si necesitas asociar Paciente o Enfermero, solo incluye sus IDs
        // public int? PacienteID { get; set; }
        // public int? EnfermeroID { get; set; }
    }
}