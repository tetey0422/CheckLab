namespace API.DTO
{
    public class RolDTO
    {
        [Key]
        public int RolID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}