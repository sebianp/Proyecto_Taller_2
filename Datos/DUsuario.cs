using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuario
    {
        //Metodo que devuelve un objeto del tipo DataTable con la lista de todos
        //los registros de categoria
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
                SqlCommand comando = new SqlCommand("usuario_listar", SqlCon);
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
                SqlCommand comando = new SqlCommand("usuario_buscar", SqlCon);
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

        public DataTable Login(string Email, string Clave)
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
                SqlCommand comando = new SqlCommand("usuario_login", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email; //Especifico el valor que envio de parametro al procedimiento
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Clave;
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

        //Metodo que busca registros activos

        //Metodo para determinar si un registro ya existe registro en tabla
        //Recibe un objeto del tipo Entidad categoria que lo almacenara como nuevo registro
        //Devuelve una cadena con los resultados de la operación
        public string Existe(string valor)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("usuario_existe", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter ParExiste = new SqlParameter(); //Se crea un objeto del tipo parametro para recibir resultado del procedimiento
                ParExiste.ParameterName = "@existe"; //Enlazamos el valor de los parametros
                ParExiste.SqlDbType = SqlDbType.Int; //Indicamos que ese parametro es un entero
                ParExiste.Direction = ParameterDirection.Output; //Indicamos que es un parametro de salida
                comando.Parameters.Add(ParExiste); //Añadimos el parametro al objeto instanciado comando
                SqlCon.Open(); //Se abre la conexion

                //Se ejecuta el comando
                comando.ExecuteNonQuery();

                respuesta = Convert.ToString(ParExiste.Value);

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

        //Metodo para insertar un nuevo registro en tabla
        //Recibe un objeto del tipo Entidad categoria que lo almacenara como nuevo registro
        //Devuelve una cadena con los resultados de la operación
        public string Insertar(Usuario Obj)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("usuario_insertar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.IdRol;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave;
                SqlCon.Open(); //Se abre la conexion

                //Establecemos el valor de la respuesta en base al resultado de la operacion
                //Solo puede tener dos valores
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

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

        //Metodo para actualizar un registro existente de la tabla
        //Recibe un objeto del tipo Entidad categoria que lo utilizara para actualizar un registro
        //Devuelve una cadena con los resultados de la operación
        public string Actualizar(Usuario Obj)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("usuario_actualizar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.IdUsuario;
                comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.IdRol;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave;
                SqlCon.Open(); //Se abre la conexion

                //Establecemos el valor de la respuesta en base al resultado de la operacion
                //Solo puede tener dos valores
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";

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

        //Método para eliminar un registro de la tabla
        //Recibe un entero que hace referencia al ID
        //Devuelve una cadena con los resultados de la operacion
        public string Eliminar(int id)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("usuario_eliminar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open(); //Se abre la conexion

                //Establecemos el valor de la respuesta en base al resultado de la operacion
                //Solo puede tener dos valores
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

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

        //Método para activar un registro de la tabla
        //Recibe un entero que hace referencia al ID
        //Devuelve una cadena con los resultados de la operacion
        public string Activar(int id)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("usuario_activar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open(); //Se abre la conexion

                //Establecemos el valor de la respuesta en base al resultado de la operacion
                //Solo puede tener dos valores
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";

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

        //Método para desactivar un registro de la tabla
        //Recibe un entero que hace referencia al ID
        //Devuelve una cadena con los resultados de la operacion
        public string Desactivar(int id)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("usuario_desactivar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open(); //Se abre la conexion

                //Establecemos el valor de la respuesta en base al resultado de la operacion
                //Solo puede tener dos valores
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";

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

        public string ExisteNumDocumento(string numDocumento)
        {
            string respuesta = ""; // Valor que devolverá el método

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();

                //SP: usuario_existe_num_documento (@num_documento, @existe OUTPUT)
                SqlCommand comando = new SqlCommand("usuario_existe_num_documento", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parámetro de entrada
                SqlParameter parDoc = new SqlParameter("@num_documento", SqlDbType.VarChar, 20);
                parDoc.Value = (numDocumento ?? string.Empty).Trim(); //Normalizo el dato
                comando.Parameters.Add(parDoc);

                //Parámetro de salida
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Bit;//el SP devuelve BIT
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);

                SqlCon.Open();
                comando.ExecuteNonQuery();

                //Convertimos BIT a "1"/"0" para mantener tu convención
                respuesta = Convert.ToBoolean(parExiste.Value) ? "1" : "0";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

    }
}
