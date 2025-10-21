using CapaEntidad;
using CapasDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNMateria
    {
        private CDMateria cdMateria = new CDMateria();

        // Obtener todas las materias para ComboBox u otra UI
        public DataTable ObtenerMaterias()
        {
            return cdMateria.ObtenerMaterias();
        }
        public void CrearMateria(CEMateria cE)
        {
            cdMateria.Crear(cE);
        }
        
    }
}

