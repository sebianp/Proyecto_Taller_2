using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NCategoria
    {
        //Las funciones declaradas van a ser estaticas (static) a nivel de clase
        //Porque no se van a generar objetos instanciando la clase NCategoria
        //Solo se va a referenciar a la clase NCategorias y al método especifico
        //Sin necesidad de crear un objeto en la capa Presentacion

        //Metodo para listar todos los elementos de la categoria
        //devuelve un objeto del tipo DataTable
        public static DataTable Listar()
        {
            //Instanciamos un objeto de la clase DCategoria
            DCategoria datos = new DCategoria();
            //Devolvemos el metodo Listar de la clase DCategoria
            return datos.Listar();

        }

        //Metodo para buscar uno o varios elementos de la categoria que devuelve un objeto del tipo DataTable
        //Parametro: valor (cadena de caracteres que asociara a un/unos registros de la DB)
        //devuelve: la tabla con uno, varios o ningun objeto dependiendo de las coincidencias
        public static DataTable Buscar(string valor)
        {
            //Instanciamos un objeto de la clase DCategoria
            DCategoria datos = new DCategoria();
            //Devolvemos el metodo buscar de la clase DCategoria incluyendo el parametro valor de busqueda
            return datos.Buscar(valor);

        }

        //Metodo para insertar una nueva categoria en la base de datos
        //Parametros: nombre y descripcion
        //Devuelve una cadena con los valores necesarios para el insert
        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria datos = new DCategoria();

            //Se verifica si la categoria que intento insertar existe o no
             string existe = datos.Existe(nombre);

            //Aplicamos la lógica dependiendo de si ya existe la categoria o no
            if (existe.Equals("1"))
            {
                //La categoria existe y se notifica al usuario
                return "La categoría ya existe";
            }
            else
            {
                //La categoría no existe por ende se procede a su creacion
                //Creamos el objeto de la clase categoria
                Categoria Obj = new Categoria();

                //Una vez instanciado el objeto de la clase categoria se le ingresan los datos
                Obj.Nombre = nombre;
                Obj.Descripcion = descripcion;

                //Al enviar el objeto al metodo insertar en DCategoria, este retorna una cadena de confirmacion
                return datos.Insertar(Obj);
            }

           

        }

        //Metodo para actualizar una categoria existente en la base de datos
        //Parametros: id, nombre y descripcion
        //Devuelve una cadena con los valores necesarios para el insert
        public static string Actualizar(int id,string nombreAnt, string nombre, string descripcion)
        {
            DCategoria datos = new DCategoria();
            //Crea el objeto de la clase categoria
            Categoria Obj = new Categoria();

            if(nombreAnt.Equals(nombre))
            {
                //Una vez instanciado el objeto de la clase categoria se le ingresan los datos
                Obj.IdCategoria = id;
                Obj.Nombre = nombre;
                Obj.Descripcion = descripcion;

                //Al enviar el objeto al metodo actualizar en DCategoria, este retorna una cadena de confirmacion
                return datos.Actualizar(Obj);
            }
            else
            {
                //Se verifica si la categoria que intento insertar existe o no
                string existe = datos.Existe(nombre);

                //Aplicamos la lógica dependiendo de si ya existe la categoria o no
                if (existe.Equals("1"))
                {
                    //La categoria existe y se notifica al usuario
                    return "La categoría ya existe";
                }
                else
                {
                    //Una vez instanciado el objeto de la clase categoria se le ingresan los datos
                    Obj.IdCategoria = id;
                    Obj.Nombre = nombre;
                    Obj.Descripcion = descripcion;
                    return datos.Actualizar(Obj);

                }
            }

            

                
        }

        //Metodo para eliminar un registro de categoria que no sea de utilidad o este obsoleto
        //Parametros: id
        //Devuelve una cadena con los resultados de la operacion
        public static string Eliminar(int id)
        {
            DCategoria datos = new DCategoria();

            return datos.Eliminar(id);
        }

        //Metodo para activar un registro de categoria que se encuentra desactivado
        //Parametros: id
        //Devuelve una cadena con los resultados de la operacion
        public static string Activar(int id)
        {
            DCategoria datos = new DCategoria();

            return datos.Activar(id);
        }

        //Metodo para desactivar un registro de categoria
        //Parametros: id
        //Devuelve una cadena con los resultados de la operacion
        public static string Desactivar(int id)
        {
            DCategoria datos = new DCategoria();

            return datos.Desactivar(id);
        }

    }
}
