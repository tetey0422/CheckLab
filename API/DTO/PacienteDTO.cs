namespace API.DTO
{
    public class PacienteDTO
    {
        [Key]
        public int PacienteID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(100)]
        public string Apellidos { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        [MaxLength(10)]
        public string Sexo { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public DateTime? Nacimiento { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioFK { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }

        public ICollection<Cita> Citas { get; set; }
    }
}