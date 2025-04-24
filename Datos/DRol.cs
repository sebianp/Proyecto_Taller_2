using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRol
    {
        public DataTable Listar()
        {
            //DataReader nos proporciona una forma de leer una secuencia de filas en una BD de SQL server
            SqlDataReader resultado;

            //DataTable representa a una tabla
            DataTable tabla = new DataTable();

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Referenciamos a la clase Conexion
                //Al no poder hacer una instancia directa porque el constructor esta encapsulado por seguridad
                //se referencia primeramente al método getInstancia()
                //CrearConexion() me devuelve una variable SqlConnection
                SqlCon = Conexion.getInstancia().CrearConexion();

                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("rol_listar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                SqlCon.Open(); //Se abre la conexion
                resultado = comando.ExecuteReader(); //Se almacena el resultado de ejecutar el comando

                //Rellenamos la DataTable con los resultados obtenidos al ejecutar el comando
                tabla.Load(resultado);

                //Si todo se ejecuto de forma correcta se devuelve la tabla con los datos
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //Siempre se ejecuta finally para cerrar la conexion a la BD
            finally
            {
                //Se verifica si la conexion esta abierta, si es así, se cierra.
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
