namespace API.DTO
{
    public class AfiliacionDTO
    {
        public int AfiliacionID { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public int EPSID { get; set; }
        public string Estado { get; set; }
        // Si necesitas mostrar el nombre de la EPS, puedes agregar:
        // public string EPSNombre { get; set; }
    }
}