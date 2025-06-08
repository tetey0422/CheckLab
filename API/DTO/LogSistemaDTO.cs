namespace API.DTO
{
    public class LogSistemaDTO
    {
        [Key]
        public int LogID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        public string Accion { get; set; }

        public DateTime FechaHora { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}