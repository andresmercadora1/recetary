using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEMenu
    {
        private int cod_menu;
        private int cod_receta;
        private String identificador_plato;
        private Double precio_menu;
        private String comentario_menu;

        public int Cod_menu { get => cod_menu; set => cod_menu = value; }
        public int Cod_receta { get => cod_receta; set => cod_receta = value; }
        public string Identificador_plato { get => identificador_plato; set => identificador_plato = value; }
        public double Precio_menu { get => precio_menu; set => precio_menu = value; }
        public string Comentario_menu { get => comentario_menu; set => comentario_menu = value; }
    }
}
