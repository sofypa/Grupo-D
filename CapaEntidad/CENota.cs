namespace CapaEntidad
{
    public class CENota
    {
        public int id_nota { get; set; }
        public string id_usuario { get; set; }
        public string codigo_materia { get; set; }
        public string id_categoria { get; set; }
        public decimal calificacion { get; set; }
        public DateTime fecha_registro { get; set; }
        public string comentario { get; set; }
        public string grupo { get; set; }
    }
}

