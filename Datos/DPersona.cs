using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DPersona
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
                SqlCommand comando = new SqlCommand("persona_listar", SqlCon);
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

        public DataTable ListarProveedores()
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
                SqlCommand comando = new SqlCommand("persona_listar_proveedores", SqlCon);
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

        public DataTable ListarClientes()
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
                SqlCommand comando = new SqlCommand("persona_listar_clientes", SqlCon);
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
                SqlCommand comando = new SqlCommand("persona_buscar", SqlCon);
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
        public DataTable BuscarProveedores(string valor)
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
                SqlCommand comando = new SqlCommand("persona_buscar_proveedores", SqlCon);
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

        public DataTable BuscarClientes(string valor)
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
                SqlCommand comando = new SqlCommand("persona_buscar_clientes", SqlCon);
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
                SqlCommand comando = new SqlCommand("persona_existe", SqlCon);
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
        public string Insertar(Persona Obj)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("persona_insertar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = Obj.TipoPersona;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email;

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
        public string Actualizar(Persona Obj)
        {
            string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

            //Variable que establece una nueva conexion con la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //SqlCommand representa una instruccion transact SQL o un procedimiento
                //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                SqlCommand comando = new SqlCommand("persona_actualizar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = Obj.IdPersona;
                comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = Obj.TipoPersona;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email;
                
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
                SqlCommand comando = new SqlCommand("persona_eliminar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = id;
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
    }
}
