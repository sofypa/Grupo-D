using CapasDatos;
using System.Data;

namespace CapaNegocio
{
    internal class CNMateria
    {
        private CDMateria cdMateria = new CDMateria();

        // Obtener todas las materias para ComboBox u otra UI
        public DataTable ObtenerMaterias()
        {
            return cdMateria.ObtenerMaterias();
        }
    }
}

