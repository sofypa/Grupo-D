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
        public DataTable ObtenerMateriasDataTable()
        {
            return cdMateria.ListarMateriasDataTable();
        }
        public void CrearMateria(CEMateria cE)
        {
            cdMateria.Crear(cE);
        }
        //Editar una materia existente
        public bool EditarMateria(CEMateria materia)
        {
            CDMateria cd = new CDMateria();
            return cd.EditarMateria(materia);
        }
        //Eliminar una materia por su código
        public bool EliminarMateria(string codigo)
        {
            CDMateria cd = new CDMateria();
            return cd.EliminarMateria(codigo);
        }
    }
}

