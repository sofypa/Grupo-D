using CapaDatos;
using CapaEntidad;
using CapasDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CNNota
    {
        CDNota cdNota = new CDNota();
        CDMateria cdMateria = new CDMateria();
        CDCategoria cdCategoria = new CDCategoria();

        public bool AgregarNota(CENota nota)
        {
            try
            {
                if (nota == null) throw new ArgumentNullException(nameof(nota));
                if (string.IsNullOrWhiteSpace(nota.codigo_materia))
                    throw new Exception("Seleccione una materia.");
                if (string.IsNullOrWhiteSpace(nota.id_categoria))
                    throw new Exception("Seleccione una categoría.");
                if (nota.calificacion < 0 || nota.calificacion > 100)
                    throw new Exception("La calificación debe estar entre 0 y 100.");

                return cdNota.InsertarNota(nota);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en AgregarNota: " + ex.Message);  // Mostrar el error exacto
                return false;
            }
        }

        public bool EditarNota(CENota nota)
        {
            if (nota == null) throw new ArgumentNullException(nameof(nota));
            if (nota.id_nota <= 0)
                throw new Exception("ID de nota inválido.");
            if (string.IsNullOrWhiteSpace(nota.id_categoria))
                throw new Exception("Seleccione una categoría.");
            if (nota.calificacion < 0 || nota.calificacion > 100)
                throw new Exception("La calificación debe estar entre 0 y 100.");

            return cdNota.EditarNota(nota);
        }

        public bool EliminarNota(int idNota)
        {
            if (idNota <= 0)
                throw new Exception("ID de nota inválido.");
            return cdNota.EliminarNota(idNota);
        }

        public List<CENotaVista> ObtenerNotasVista(string codigoMateria, string idUsuario, string idCategoria)
        {
            return cdNota.ObtenerNotasVista(codigoMateria, idUsuario, idCategoria);
        }

        public decimal CalcularPromedio(string codigoMateria, string idUsuario)
        {
            return cdNota.ObtenerPromedioMateria(codigoMateria, idUsuario);
        }
        public DataTable ObtenerMaterias()
        {
            return cdMateria.ListarMateriasDataTable(); // o cdMateria.ObtenerMaterias()
        }

        public DataTable ObtenerCategorias()
        {
            return cdCategoria.ObtenerCatalogoCategorias(); // tu método existente
        }
    }
}
