using CapaDatos;
using CapaEntidad;
using CapasDatos;
using System.Data;

namespace CapasNegocio
{
    public class CNCategoria
    {
        private CDCategoria datos = new CDCategoria();

        public bool Validar(CECategoria c)
        {
            if (string.IsNullOrWhiteSpace(c.IdCategoria))
            {
                MessageBox.Show("El ID de categoría es requerido.");
                return false;
            }
            if (c.Ponderacion < 0 || c.Ponderacion > 100)
            {
                MessageBox.Show("La ponderación debe estar entre 0 y 100.");
                return false;
            }
            return true;
        }

        public void CrearCategoria(CECategoria c)
        {
            datos.InsertarCategoria(c);
        }

        public DataTable ObtenerCategoriasPorMateria(string codigoMateria)
        {
            return datos.ObtenerCategoriasPorMateria(codigoMateria);
        }
        public void EditarCategoria(CECategoria c)
        {
            if (!Validar(c)) return;
            datos.ActualizarCategoria(c);
        }

        public void BorrarCategoria(string idCategoria, string codigoMateria)
        {
            datos.EliminarCategoria(idCategoria, codigoMateria);
        }
        public List<string> ObtenerNombresCategoriasUnicos()
        {
            return datos.ObtenerNombresCategoriasUnicos();
        }
        public DataTable ObtenerCatalogoCategorias()
        {
            return datos.ObtenerCatalogoCategorias();
        }
        public bool ExisteCategoria(string idCategoria, string codigoMateria)
        {
            return datos.ExisteCategoria(idCategoria, codigoMateria);
        }
    }
}