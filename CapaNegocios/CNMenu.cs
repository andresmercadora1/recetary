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
    public class CNMenu
    {
        CDMenu oDatMenu = new CDMenu();
        public bool guardarMenu(CEMenu oMenu)
        {
            return oDatMenu.guardarMenu(oMenu);
        }

        public bool modificarrMenu(CEMenu oMenu)
        {
            return oDatMenu.modificarrMenu(oMenu);
        }

        public bool eliminarMenu(CEMenu oMenu)
        {
            return oDatMenu.eliminarMenu(oMenu);
        }

        public DataSet consultarMenu(CEMenu oMenu)
        {
            return oDatMenu.consultarMenu(oMenu);
        }
    }
}
