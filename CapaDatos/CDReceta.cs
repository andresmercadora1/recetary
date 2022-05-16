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
    public class CDReceta
    {
        Conexion objConexion = new Conexion();
        SqlCommand objCommand = new SqlCommand();
        public bool guardarReceta(CEReceta oReceta)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "agregar_receta"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_receta", oReceta.Cod_receta);
                objCommand.Parameters.AddWithValue("@fuente_receta", oReceta.Fuente_receta);
                objCommand.Parameters.AddWithValue("@ubicacion_receta", oReceta.Ubicacion_receta);
                objCommand.Parameters.AddWithValue("@lista_ingredientes", oReceta.Lista_ingredientes);
                objCommand.Parameters.AddWithValue("@utensilios", oReceta.Utensilios);
                objCommand.Parameters.AddWithValue("@tiempo_ejecucion", oReceta.Tiempo_ejecucion);
                objCommand.Parameters.AddWithValue("@comentario_receta", oReceta.Comentario_receta);

                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {

                throw;
            }
        }

        public bool modificarrReceta(CEReceta oReceta)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "modificar_receta"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_receta", oReceta.Cod_receta);
                objCommand.Parameters.AddWithValue("@fuente_receta", oReceta.Fuente_receta);
                objCommand.Parameters.AddWithValue("@ubicacion_receta", oReceta.Ubicacion_receta);
                objCommand.Parameters.AddWithValue("@lista_ingredientes", oReceta.Lista_ingredientes);
                objCommand.Parameters.AddWithValue("@utensilios", oReceta.Utensilios);
                objCommand.Parameters.AddWithValue("@tiempo_ejecucion", oReceta.Tiempo_ejecucion);
                objCommand.Parameters.AddWithValue("@comentario_receta", oReceta.Comentario_receta);

                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultarReceta (CEReceta oReceta)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "consulta_receta";
                objCommand.Parameters.AddWithValue("@cod_receta", oReceta.Cod_receta);
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

        public bool eliminarReceta(CEReceta oReceta)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "eliminar_receta"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_receta", oReceta.Cod_receta);
               
                
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
