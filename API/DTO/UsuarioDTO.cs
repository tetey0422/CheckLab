namespace API.DTO
{
    public class UsuarioDTO
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [MaxLength(10)]
        public string TipoDocumento { get; set; }

        [Required]
        [MaxLength(20)]
        public string Documento { get; set; }

        [Required]
        public string Contraseña { get; set; }

        [ForeignKey("Rol")]
        public int RolID { get; set; }
        public Rol Rol { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }

        public Paciente Paciente { get; set; }
        public Enfermero Enfermero { get; set; }
        public ICollection<Notificacion> Notificaciones { get; set; }
        public ICollection<LogSistema> Logs { get; set; }
    }
}