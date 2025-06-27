using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPersona
    {
        public static DataTable Listar()
        {
            //Instanciamos un objeto de la clase
            DPersona datos = new DPersona();
            //Devolvemos el metodo Listar de la clase
            return datos.Listar();

        }

        public static DataTable ListarProveedores()
        {
            //Instanciamos un objeto de la clase
            DPersona datos = new DPersona();
            //Devolvemos el metodo Listar de la clase
            return datos.ListarProveedores();

        }

        public static DataTable ListarClientes()
        {
            //Instanciamos un objeto de la clase
            DPersona datos = new DPersona();
            //Devolvemos el metodo Listar de la clase
            return datos.ListarClientes();

        }

        //Metodo para buscar uno o varios elementos de la categoria que devuelve un objeto del tipo DataTable
        //Parametro: valor (cadena de caracteres que asociara a un/unos registros de la DB)
        //devuelve: la tabla con uno, varios o ningun objeto dependiendo de las coincidencias
        public static DataTable Buscar(string valor)
        {
            //Instanciamos un objeto de la clase
            DPersona datos = new DPersona();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.Buscar(valor);

        }

        public static DataTable BuscarProveedores(string valor)
        {
            //Instanciamos un objeto de la clase
            DPersona datos = new DPersona();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.BuscarProveedores(valor);

        }

        public static DataTable BuscarClientes(string valor)
        {
            //Instanciamos un objeto de la clase
            DPersona datos = new DPersona();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.BuscarClientes(valor);

        }


        //Metodo para insertar una nueva categoria en la base de datos
        //Devuelve una cadena con los resultados
        public static string Insertar(string TipoPersona, string nombre, string tipoDocumento, string numDocumento, string direccion, string telefono, string email)
        {
            DPersona datos = new DPersona();

            //Se verifica si la categoria que intento insertar existe o no
            string existe = datos.Existe(nombre);

            //Aplicamos la lógica dependiendo de si ya existe el objeto
            if (existe.Equals("1"))
            {
                //Si existe y se notifica al usuario
                return "La persona con ese nombre ya existe";
            }
            else
            {
                //Si el objeto no existe por ende se procede a su creacion
                //Creamos el objeto de la clase
                Persona Obj = new Persona();

                //Una vez instanciado el objeto se ingresan los datos
                Obj.TipoPersona = TipoPersona;
                Obj.Nombre = nombre;
                Obj.TipoDocumento = tipoDocumento;
                Obj.NumDocumento = numDocumento;
                Obj.Direccion = direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                
                //Al enviar el objeto al metodo insertar, este retorna una cadena de confirmacion
                return datos.Insertar(Obj);
            }
        }

        //Metodo para actualizar un objeto existente en la base de datos
        //Devuelve una cadena los resultados de la operacion.
        public static string Actualizar(int id, string tipoPersona, string nombreAnt, string nombre, string tipoDocumento, string numDocumento, string direccion, string telefono, string email)
        {
            DPersona datos = new DPersona();
            //Crea el objeto de la clase
            Persona Obj = new Persona();

            //Si existe el nombre quiere decir que no se esta modificando el nombre, sino los otros parametros.
            if (nombreAnt.Equals(nombre))
            {
                //Una vez instanciado el objeto de la clase se le ingresan los datos
                Obj.IdPersona = id;
                Obj.TipoPersona = tipoPersona;
                Obj.Nombre = nombre;
                Obj.TipoDocumento = tipoDocumento;
                Obj.NumDocumento = numDocumento;
                Obj.Direccion = direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                

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
                    return "Ya existe una persona con ese nombre";
                }
                else
                {
                    //Una vez instanciado el objeto de la clase se ingresan los datos
                    Obj.IdPersona = id;
                    Obj.TipoPersona = tipoPersona;
                    Obj.Nombre = nombre;
                    Obj.TipoDocumento = tipoDocumento;
                    Obj.NumDocumento = numDocumento;
                    Obj.Direccion = direccion;
                    Obj.Telefono = telefono;
                    Obj.Email = email;
                    return datos.Actualizar(Obj);

                }
            }
        }

        //Metodo para eliminar un registro que no sea de utilidad o este obsoleto
        //Devuelve una cadena con los resultados de la operacion
        public static string Eliminar(int id)
        {
            DPersona datos = new DPersona();

            return datos.Eliminar(id);
        }
    }
}
