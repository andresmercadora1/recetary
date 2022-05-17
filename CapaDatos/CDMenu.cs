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
    public class CDMenu
    {
        Conexion objConexion = new Conexion();
        SqlCommand objCommand = new SqlCommand();
        public bool guardarMenu(CEMenu oMenu)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "agregar_menu"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_menu", oMenu.Cod_menu);
                objCommand.Parameters.AddWithValue("@cod_receta", oMenu.Cod_receta);
                objCommand.Parameters.AddWithValue("@identificador_plato", oMenu.Identificador_plato);
                objCommand.Parameters.AddWithValue("@precio_menu", oMenu.Precio_menu);
                objCommand.Parameters.AddWithValue("@comentario_menu", oMenu.Comentario_menu);


                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool modificarrMenu(CEMenu oMenu)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "modificar_menu"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_menu", oMenu.Cod_menu);
                objCommand.Parameters.AddWithValue("@cod_receta", oMenu.Cod_receta);
                objCommand.Parameters.AddWithValue("@identificador_plato", oMenu.Identificador_plato);
                objCommand.Parameters.AddWithValue("@precio_menu", oMenu.Precio_menu);
                objCommand.Parameters.AddWithValue("@comentario_menu", oMenu.Comentario_menu);

                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultarMenu(CEMenu oMenu)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "consultar_menu";
                objCommand.Parameters.AddWithValue("@cod_menu", oMenu.Cod_menu);
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

        public bool eliminarMenu(CEMenu oMenu)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("BDRecetary");
                objCommand.CommandText = "eliminar_menu"; //Nombre del procedimiento almacenado en DB
                objCommand.Parameters.AddWithValue("@cod_menu", oMenu.Cod_menu);


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
