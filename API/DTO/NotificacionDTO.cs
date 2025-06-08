namespace API.DTO
{
    public class NotificacionDTO
    {
        [Key]
        public int NotificacionID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        public string Mensaje { get; set; }

        public bool Leida { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}