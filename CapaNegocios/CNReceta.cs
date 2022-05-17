using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CNReceta
    {
        CDReceta oDatReceta = new CDReceta();
        public bool guardarReceta(CEReceta oReceta)
        {
            return oDatReceta.guardarReceta(oReceta);
        }

        public bool modificarrReceta(CEReceta oReceta)
        {
            return oDatReceta.modificarrReceta(oReceta);
        }

        public bool eliminarReceta(CEReceta oReceta)
        {
            return oDatReceta.eliminarReceta(oReceta);
        }

        public DataSet consultarReceta(CEReceta oReceta)
        {
            return oDatReceta.consultarReceta(oReceta);
        }
    }
}
