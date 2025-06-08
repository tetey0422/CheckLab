namespace API.DTO
{
    public class EnfermeroDTO
    {
        [Key]
        public int EnfermeroID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(100)]
        public string Apellidos { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioFK { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}