using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEPlato
    {
        private int cod_plato;
        private int cod_receta;
        private String tipo_plato;
        private String nombre_plato;
        private String ingrediente_principal;
        private Double calorias_plato;
        private Double cantidad_ing_plato;
        private String unidad_medida_plato;
        private Double precio_plato;
        private String comentario_adicional_plato;

        public int Cod_plato { get => cod_plato; set => cod_plato = value; }
        public int Cod_receta { get => cod_receta; set => cod_receta = value; }
        public string Tipo_plato { get => tipo_plato; set => tipo_plato = value; }
        public string Nombre_plato { get => nombre_plato; set => nombre_plato = value; }
        public string Ingrediente_principal { get => ingrediente_principal; set => ingrediente_principal = value; }
        public double Calorias_plato { get => calorias_plato; set => calorias_plato = value; }
        public double Cantidad_ing_plato { get => cantidad_ing_plato; set => cantidad_ing_plato = value; }
        public string Unidad_medida_plato { get => unidad_medida_plato; set => unidad_medida_plato = value; }
        public double Precio_plato { get => precio_plato; set => precio_plato = value; }
        public string Comentario_adicional_plato { get => comentario_adicional_plato; set => comentario_adicional_plato = value; }
    }
}
