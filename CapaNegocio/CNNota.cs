using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNNota
    {
        private readonly CDNota cdNota = new CDNota();

        // -------------------------------------------------------------
        // REGISTRAR NOTA
        // -------------------------------------------------------------
        public bool RegistrarNota(CENota nota, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio
            if (nota.calificacion < 0 || nota.calificacion > 100)
            {
                mensaje = "La calificación debe estar entre 0 y 100.";
                return false;
            }

            if (nota.id_categoria <= 0)
            {
                mensaje = "Debe seleccionar una categoría.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(nota.codigo_materia))
            {
                mensaje = "La materia es obligatoria.";
                return false;
            }

            // Enviar a capa datos
            bool resultado = cdNota.InsertarNota(nota);

            if (!resultado)
                mensaje = "Error al registrar la nota.";

            return resultado;
        }

        // -------------------------------------------------------------
        // EDITAR NOTA
        // -------------------------------------------------------------
        public bool EditarNota(CENota nota, out string mensaje)
        {
            mensaje = string.Empty;

            if (nota.calificacion < 0 || nota.calificacion > 100)
            {
                mensaje = "La calificación debe estar entre 0 y 100.";
                return false;
            }

            if (nota.id_nota <= 0)
            {
                mensaje = "ID de nota inválido.";
                return false;
            }

            bool resultado = cdNota.EditarNota(nota);

            if (!resultado)
                mensaje = "Error al editar la nota.";

            return resultado;
        }

        // -------------------------------------------------------------
        // ELIMINAR NOTA
        // -------------------------------------------------------------
        public bool EliminarNota(int idNota, out string mensaje)
        {
            mensaje = string.Empty;

            if (idNota <= 0)
            {
                mensaje = "ID de nota inválido.";
                return false;
            }

            bool resultado = cdNota.EliminarNota(idNota);

            if (!resultado)
                mensaje = "No se pudo eliminar la nota.";

            return resultado;
        }

        // -------------------------------------------------------------
        // LISTAR NOTAS
        // -------------------------------------------------------------
        public DataTable ObtenerNotasPorMateria(string codigoMateria)
        {
            return cdNota.ObtenerNotasPorMateria(codigoMateria);
        }

        // -------------------------------------------------------------
        // LISTAR NOTAS (VISTA)
        // -------------------------------------------------------------
        public List<CENotaVista> ObtenerNotasVista(string codigoMateria, string idUsuario)
        {
            return cdNota.ObtenerNotasVista(codigoMateria, idUsuario);
        }

        // -------------------------------------------------------------
        // CALCULAR PROMEDIO SIMPLE (lo que tu CDNota tiene)
        // -------------------------------------------------------------
        public decimal ObtenerPromedio(string codigoMateria, string idUsuario)
        {
            return cdNota.ObtenerPromedioMateria(codigoMateria, idUsuario);
        }

        // -------------------------------------------------------------
        // PROMEDIO POR CATEGORÍA (opcional)
        // -------------------------------------------------------------
        public decimal ObtenerPromedioCategoria(string codigoMateria, string idUsuario, string categoria)
        {
            List<CENotaVista> lista = cdNota.ObtenerNotasVista(codigoMateria, idUsuario);

            decimal suma = 0;
            int contador = 0;

            foreach (var n in lista)
            {
                if (n.categoria == categoria)
                {
                    suma += n.Nota;
                    contador++;
                }
            }

            if (contador == 0)
                return 0;

            return Math.Round(suma / contador, 2);
        }
    }
}
