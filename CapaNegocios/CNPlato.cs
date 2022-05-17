using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocios
{
    public class CNPlato
    {
        CDPlato oDatPlato = new CDPlato();
        public bool guardarPlato(CEPlato oPlato)
        {
            return oDatPlato.guardarPlato(oPlato);
        }

        public bool modificarrReceta(CEPlato oPlato)
        {
            return oDatPlato.modificarrReceta(oPlato);
        }

        public bool eliminarReceta(CEPlato oPlato)
        {
            return oDatPlato.eliminarReceta(oPlato);
        }

        public DataSet consultarReceta(CEPlato oPlato)
        {
            return oDatPlato.consultarReceta(oPlato);
        }
    }
}
