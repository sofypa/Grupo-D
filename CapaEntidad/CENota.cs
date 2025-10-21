namespace CapaEntidad
{
    public class CENota
    {
        public string IdUsuario { get; set; }       // ID del usuario
        public string CodigoMateria { get; set; }   // Código de la materia
        public string IdCategoria { get; set; }     // ID de la categoría de la nota
        public double Calificacion { get; set; }   // Nota obtenida
        public string Comentario { get; set; }      // Comentario adicional
    }
}

