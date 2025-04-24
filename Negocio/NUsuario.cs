using Datos;
using Entidades; //Espacio de nombres
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuario
    {
        //Las funciones declaradas van a ser estaticas (static) a nivel de clase
        //Porque no se van a generar objetos instanciando la clase
        //Solo se va a referenciarla y al método especifico
        //Sin necesidad de crear un objeto en la capa Presentacion

        //Metodo para listar todos los elementos de articulos
        //devuelve un objeto del tipo DataTable
        public static DataTable Listar()
        {
            //Instanciamos un objeto de la clase
            DUsuario datos = new DUsuario();
            //Devolvemos el metodo Listar de la clase
            return datos.Listar();

        }

        //Metodo para buscar uno o varios elementos de la categoria que devuelve un objeto del tipo DataTable
        //Parametro: valor (cadena de caracteres que asociara a un/unos registros de la DB)
        //devuelve: la tabla con uno, varios o ningun objeto dependiendo de las coincidencias
        public static DataTable Buscar(string valor)
        {
            //Instanciamos un objeto de la clase
            DUsuario datos = new DUsuario();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.Buscar(valor);

        }

        //Método para el ingreso de usuarios al sistema
        public static DataTable Login(string Email, string Clave)
        {
            //Instanciamos un objeto de la clase
            DUsuario datos = new DUsuario();
            //Devolvemos el metodo login de la clase incluyendo los parametros de acceso
            return datos.Login(Email,Clave);

        }

        //Metodo para insertar una nueva categoria en la base de datos
        //Devuelve una cadena con los resultados
        public static string Insertar(int idRol, string nombre, string tipoDocumento, string numDocumento, string direccion, string telefono, string email, string clave)
        {
            DUsuario datos = new DUsuario();

            //Se verifica si la categoria que intento insertar existe o no
            string existe = datos.Existe(email);

            //Aplicamos la lógica dependiendo de si ya existe el objeto
            if (existe.Equals("1"))
            {
                //Si existe y se notifica al usuario
                return "El usuario con ese Email ya existe";
            }
            else
            {
                //Si el objeto no existe por ende se procede a su creacion
                //Creamos el objeto de la clase
                Usuario Obj = new Usuario();

                //Una vez instanciado el objeto se ingresan los datos
                Obj.IdRol = idRol;
                Obj.Nombre = nombre;
                Obj.TipoDocumento = tipoDocumento;
                Obj.NumDocumento = numDocumento;
                Obj.Direccion = direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                Obj.Clave = clave;

                //Al enviar el objeto al metodo insertar, este retorna una cadena de confirmacion
                return datos.Insertar(Obj);
            }
        }

        //Metodo para actualizar un objeto existente en la base de datos
        //Devuelve una cadena los resultados de la operacion.
        public static string Actualizar(int id, int idRol, string nombre, string tipoDocumento, string numDocumento, string direccion, string telefono, string emailAnt, string email, string clave)
        {
            DUsuario datos = new DUsuario();
            //Crea el objeto de la clase
            Usuario Obj = new Usuario();

            //Si existe el nombre quiere decir que no se esta modificando el nombre, sino los otros parametros.
            if (emailAnt.Equals(email))
            {
                //Una vez instanciado el objeto de la clase se le ingresan los datos
                Obj.IdUsuario = id;
                Obj.IdRol = idRol;
                Obj.Nombre = nombre;
                Obj.TipoDocumento = tipoDocumento;
                Obj.NumDocumento = numDocumento;
                Obj.Direccion = direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                Obj.Clave = clave;

                //Al enviar el objeto al metodo actualizar este retorna una cadena de confirmacion
                return datos.Actualizar(Obj);
            }
            else
            {
                //Se verifica si el objeto que intento insertar ya existe
                string existe = datos.Existe(nombre);

                //Aplicamos la lógica dependiendo de si ya existe el objeto
                if (existe.Equals("1"))
                {
                    //El objeto existe y se notifica al usuario
                    return "El usuario con ese Email ya existe";
                }
                else
                {
                    //Una vez instanciado el objeto de la clase se ingresan los datos
                    Obj.IdUsuario = id;
                    Obj.IdRol = idRol;
                    Obj.Nombre = nombre;
                    Obj.TipoDocumento = tipoDocumento;
                    Obj.NumDocumento = numDocumento;
                    Obj.Direccion = direccion;
                    Obj.Telefono = telefono;
                    Obj.Email = email;
                    Obj.Clave = clave;
                    return datos.Actualizar(Obj);

                }
            }
        }

        //Metodo para eliminar un registro que no sea de utilidad o este obsoleto
        //Devuelve una cadena con los resultados de la operacion
        public static string Eliminar(int id)
        {
            DUsuario datos = new DUsuario();

            return datos.Eliminar(id);
        }

        //Metodo para activar un registro que se encuentra desactivado
        //Devuelve una cadena con los resultados de la operacion
        public static string Activar(int id)
        {
            DUsuario datos = new DUsuario();

            return datos.Activar(id);
        }

        //Metodo para desactivar un registro
        //Devuelve una cadena con los resultados de la operacion
        public static string Desactivar(int id)
        {
            DUsuario datos = new DUsuario();

            return datos.Desactivar(id);
        }
    }
}
