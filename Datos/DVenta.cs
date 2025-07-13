using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVenta
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
                SqlCommand comando = new SqlCommand("venta_listar", SqlCon);
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

        //Metodo para buscar registros de la tabla que coincidan con un valor
        //Recibe un parámetro string con el que buscará las coincidencias
        //Devuelve un objeto del tipo DataTable que contendrá la lista de los registros que coinciden
        public DataTable Buscar(string valor)
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
                SqlCommand comando = new SqlCommand("venta_buscar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor; //Especifico el valor que envio de parametro al procedimiento
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

        public DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
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
                SqlCommand comando = new SqlCommand("venta_consulta_fechas", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = FechaInicio; //Especifico el valor que envio de parametro al procedimiento
                comando.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = FechaFin; //Especifico el valor que envio de parametro al procedimiento
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

        public DataTable ListarDetalle(int Id)
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
                SqlCommand comando = new SqlCommand("venta_listar_detalle", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id; //Especifico el valor que envio de parametro al procedimiento
                SqlCon.Open(); //Se abre la conexion
                resultado = comando.ExecuteReader(); //Se almacena el resultado de ejecutar el comando

                //Rellenamos la DataTable con los resultados obtenidos al ejecutar el comando
                tabla.Load(resultado);

                //Si todo se ejecuto de forma correcta se devuelve la tabla con los datos
                return tabla;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            //Siempre se ejecuta finally para cerrar la conexion a la BD
            finally
            {
                //Se verifica si la conexion esta abierta, si es así, se cierra.
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }

        public string Insertar(Venta Obj)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("venta_insertar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idcliente", SqlDbType.Int).Value = Obj.IdCliente;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.IdUsuario;
                comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = Obj.TipoComprobante;
                comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = Obj.SerieComprobante;
                comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = Obj.NumComprobante;
                comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = Obj.Impuesto;
                comando.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.Total;
                comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = Obj.Detalles;
                //La fecha y el estado del ingreso son establecidas por defecto en la base de datos

                SqlCon.Open(); //Se abre la conexion

                comando.ExecuteNonQuery();
                //Establecemos el valor de la respuesta 
                respuesta = "OK";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                //Se verifica si la conexion esta abierta, si es así, se cierra.
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        public string Anular(int id)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("venta_anular", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idventa", SqlDbType.Int).Value = id;
                SqlCon.Open(); //Se abre la conexion

                comando.ExecuteNonQuery();
                respuesta = "OK";
                //respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo anular el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                //Se verifica si la conexion esta abierta, si es así, se cierra.
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;

        }
    }
}
