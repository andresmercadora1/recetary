using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CDPlato
    {
        Conexion objConexion = new Conexion();
        SqlCommand objCommand = new SqlCommand();
        public bool guardarPlato(CEPlato oPlato)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "agregar_plato"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_plato", oPlato.Cod_plato);
                objCommand.Parameters.AddWithValue("@cod_receta", oPlato.Cod_receta);
                objCommand.Parameters.AddWithValue("@tipo_plato", oPlato.Tipo_plato);
                objCommand.Parameters.AddWithValue("@nombre_plato", oPlato.Nombre_plato);
                objCommand.Parameters.AddWithValue("@ingrediente_principal", oPlato.Ingrediente_principal);
                objCommand.Parameters.AddWithValue("@calorias_plato", oPlato.Calorias_plato);
                objCommand.Parameters.AddWithValue("@cantidad_ing_plato", oPlato.Cantidad_ing_plato);
                objCommand.Parameters.AddWithValue("@unidad_medida_plato", oPlato.Unidad_medida_plato);
                objCommand.Parameters.AddWithValue("@precio_plato", oPlato.Precio_plato);
                objCommand.Parameters.AddWithValue("@comentario_adicional_plato", oPlato.Comentario_adicional_plato);

                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool modificarrReceta(CEPlato oPlato)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "modificar_plato"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_plato", oPlato.Cod_plato);
                objCommand.Parameters.AddWithValue("@cod_receta", oPlato.Cod_receta);
                objCommand.Parameters.AddWithValue("@tipo_plato", oPlato.Tipo_plato);
                objCommand.Parameters.AddWithValue("@nombre_plato", oPlato.Nombre_plato);
                objCommand.Parameters.AddWithValue("@ingrediente_principal", oPlato.Ingrediente_principal);
                objCommand.Parameters.AddWithValue("@calorias_plato", oPlato.Calorias_plato);
                objCommand.Parameters.AddWithValue("@cantidad_ing_plato", oPlato.Cantidad_ing_plato);
                objCommand.Parameters.AddWithValue("@unidad_medida_plato", oPlato.Unidad_medida_plato);
                objCommand.Parameters.AddWithValue("@precio_plato", oPlato.Precio_plato);
                objCommand.Parameters.AddWithValue("@comentario_adicional_plato", oPlato.Comentario_adicional_plato);

                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultarReceta(CEPlato oPlato)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "consultar_plato";
                objCommand.Parameters.AddWithValue("@cod_plato", oPlato.Cod_plato);
                SqlDataAdapter dat = new SqlDataAdapter(objCommand);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarReceta(CEPlato oPlato)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "eliminar_plato"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_plato", oPlato.Cod_plato);

                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
