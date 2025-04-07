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
    
    
        //Esta clase contiene las funciones para poder manipular los datos de la BD
        //referentes a Articulos
        public class DArticulo
        {
            //Metodo que devuelve un objeto del tipo DataTable con la lista de todos
            //los registros de Articulos
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
                    SqlCommand comando = new SqlCommand("articulo_listar", SqlCon);
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

            //Metodo para buscar registros de la tabla categoria que coincidan con un valor
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
                    SqlCommand comando = new SqlCommand("articulo_buscar", SqlCon);
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

            //Metodo para determinar si un registro ya existe registro en tabla categoria
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
                    SqlCommand comando = new SqlCommand("articulo_existe", SqlCon);
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

            //Metodo para insertar un nuevo registro en tabla categoria
            //Recibe un objeto del tipo Entidad categoria que lo almacenara como nuevo registro
            //Devuelve una cadena con los resultados de la operación
            public string Insertar(Articulo Obj)
            {
                string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

                //Variable que establece una nueva conexion con la BD
                SqlConnection SqlCon = new SqlConnection();

                try
                {
                    SqlCon = Conexion.getInstancia().CrearConexion();
                    //SqlCommand representa una instruccion transact SQL o un procedimiento
                    //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                    SqlCommand comando = new SqlCommand("articulo_insertar", SqlCon);
                    comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                    comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                    comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                    comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta;
                    comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock;
                    comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                    comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen;

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

            //Metodo para actualizar un registro existente de la tabla categoria
            //Recibe un objeto del tipo Entidad categoria que lo utilizara para actualizar un registro
            //Devuelve una cadena con los resultados de la operación
            public string Actualizar(Articulo Obj)
            {
                string respuesta = ""; //Iniciamos la variable de respuesta que devuelve el metodo en base a lo obtenido

                //Variable que establece una nueva conexion con la BD
                SqlConnection SqlCon = new SqlConnection();

                try
                {
                    SqlCon = Conexion.getInstancia().CrearConexion();
                    //SqlCommand representa una instruccion transact SQL o un procedimiento
                    //Recibe dos parametros: el nombre del procedimiento y la conexion a la BD especifica
                    SqlCommand comando = new SqlCommand("articulo_actualizar", SqlCon);
                    comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                    comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Obj.IdArticulo;
                    comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                    comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                    comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta;
                    comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock;
                    comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                    comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen;
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

            //Método para eliminar un registro de la tabla categoria
            //Recibe un entero que hace referencia al ID de la categoria
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
                    SqlCommand comando = new SqlCommand("articulo_eliminar", SqlCon);
                    comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                    comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
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

            //Método para activar un registro de la tabla categoria
            //Recibe un entero que hace referencia al ID de la categoria
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
                    SqlCommand comando = new SqlCommand("articulo_activar", SqlCon);
                    comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                    comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
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

            //Método para desactivar un registro de la tabla categoria
            //Recibe un entero que hace referencia al ID de la categoria
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
                    SqlCommand comando = new SqlCommand("articulo_desactivar", SqlCon);
                    comando.CommandType = CommandType.StoredProcedure; //Indico que estoy haciendo referencia a un comando de la BD
                    comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
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
        
    }
}
