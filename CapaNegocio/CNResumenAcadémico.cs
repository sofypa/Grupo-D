using CapasDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CNResumenAcadémico
    {
        private CDResumenAcadémico cdDashboard = new CDResumenAcadémico();

        // Método para obtener el resumen por materia desde la vista_dashboard
        public List<CEResumenAcadémico> ObtenerResumenPorMateria()
        {
            return cdDashboard.ObtenerResumenPorMateria();
        }
    }
}