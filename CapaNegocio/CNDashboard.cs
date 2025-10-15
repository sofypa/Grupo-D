using CapasDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNDashboard
    {
        CDDashboard cdDashboard = new CDDashboard();

        public DataTable ObtenerGrupos()
        {
            return cdDashboard.ObtenerGrupos();
        }

        public DataTable ObtenerDatosDashboard()
        {
            return cdDashboard.ObtenerDatosDashboard();
        }

        public String prueba()
        {
            return "";
        }
    }
}
