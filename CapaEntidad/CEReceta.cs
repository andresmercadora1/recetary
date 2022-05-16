using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEReceta
    {
        private int cod_receta;
        private String fuente_receta;
        private String ubicacion_receta;
        private String lista_ingredientes;
        private String utensilios;
        private DateTime tiempo_ejecucion;
        private String comentario_receta;

        public int Cod_receta { get => cod_receta; set => cod_receta = value; }
        public string Fuente_receta { get => fuente_receta; set => fuente_receta = value; }
        public string Ubicacion_receta { get => ubicacion_receta; set => ubicacion_receta = value; }
        public string Lista_ingredientes { get => lista_ingredientes; set => lista_ingredientes = value; }
        public string Utensilios { get => utensilios; set => utensilios = value; }
        public DateTime Tiempo_ejecucion { get => tiempo_ejecucion; set => tiempo_ejecucion = value; }
        public string Comentario_receta { get => comentario_receta; set => comentario_receta = value; }
    }
}
