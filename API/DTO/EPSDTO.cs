namespace API.DTO
{
    public class EPSDTO
    {
        [Key]
        public int EPSID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}