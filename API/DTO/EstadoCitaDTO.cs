namespace API.DTO
{
    public class EstadoCitaDTO
    {
        [Key]
        public int EstadoID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Descripcion { get; set; }

        public ICollection<Cita> Citas { get; set; }
    }
}