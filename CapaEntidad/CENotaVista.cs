namespace CapaEntidad
{
    public class CENotaVista
    {
        public int id_nota { get; set; }
        public string materia { get; set; }
        public string categoria { get; set; }
        public decimal Nota { get; set; }
        public string comentario { get; set; }
        public int total_posible { get; set; }
        public string NotaTexto => $"{Nota}/{total_posible}";
    }

}
