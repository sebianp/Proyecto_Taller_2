using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio
{
    public class NArticulo
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
            DArticulo datos = new DArticulo();
            //Devolvemos el metodo Listar de la clase
            return datos.Listar();

        }

        //Metodo para buscar uno o varios elementos de la categoria que devuelve un objeto del tipo DataTable
        //Parametro: valor (cadena de caracteres que asociara a un/unos registros de la DB)
        //devuelve: la tabla con uno, varios o ningun objeto dependiendo de las coincidencias
        public static DataTable Buscar(string valor)
        {
            //Instanciamos un objeto de la clase
            DArticulo datos = new DArticulo();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.Buscar(valor);

        }

        public static DataTable BuscarVentaFiltros(string texto, int idCategoria, string marca)
        {
            //Instanciamos un objeto de la clase
            DArticulo datos = new DArticulo();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.BuscarVentaFiltros(texto, idCategoria, marca);
        }

        public static DataTable BuscarFiltros(string texto, int idCategoria, string marca)
        {
            //Instanciamos un objeto de la clase
            DArticulo datos = new DArticulo();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.BuscarFiltros(texto, idCategoria, marca);
        }

        public static DataTable BuscarVenta(string valor)
        {
            //Instanciamos un objeto de la clase
            DArticulo datos = new DArticulo();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.BuscarVenta(valor);

        }


        //Metodo para buscar un elemento que coincida con el codigo ingresado
        //Parametro: valor (cadena de caracteres que asociara a un/unos registros de la DB)
        //Devuelve: un articulo (o ninguno) dependiendo de que haya coincidencia con el código o no.
        public static DataTable BuscarCodigo(string valor)
        {
            //Instanciamos un objeto de la clase
            DArticulo datos = new DArticulo();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.BuscarCodigo(valor);

        }

        public static DataTable BuscarCodigoVenta(string valor)
        {
            //Instanciamos un objeto de la clase
            DArticulo datos = new DArticulo();
            //Devolvemos el metodo buscar de la clase incluyendo el parametro valor de busqueda
            return datos.BuscarCodigoVenta(valor);

        }
        //Metodo para insertar una nueva categoria en la base de datos
        //Devuelve una cadena con los resultados
        public static string Insertar(int idCategoria, string codigo ,string nombre, string marca, string memoria, string color, decimal precioVenta, int stock, string descripcion, string imagen)
        {
            DArticulo datos = new DArticulo();

            //Se verifica si la categoria que intento insertar existe o no
            string existe = datos.Existe(nombre, marca, memoria, color);

            //Aplicamos la lógica dependiendo de si ya existe el objeto
            if (existe.Equals("1"))
            {
                //Si existe y se notifica al usuario
                return "El articulo ya existe";
            }
            else
            {
                //Si el objeto no existe por ende se procede a su creacion
                //Creamos el objeto de la clase
                Articulo Obj = new Articulo();

                //Una vez instanciado el objeto se ingresan los datos
                Obj.IdCategoria = idCategoria;
                Obj.Codigo = codigo;
                Obj.Nombre = nombre;
                Obj.Marca = marca;
                Obj.Memoria = memoria;
                Obj.Color = color;
                Obj.PrecioVenta = precioVenta;
                Obj.Stock = stock;
                Obj.Descripcion = descripcion;
                Obj.Imagen = imagen;

                //Al enviar el objeto al metodo insertar, este retorna una cadena de confirmacion
                return datos.Insertar(Obj);
            }



        }

        //Metodo para actualizar un objeto existente en la base de datos
        //Devuelve una cadena los resultados de la operacion.
        public static string Actualizar(int id, int idCategoria, string codigo, string nombreAnt, string marcaAnt, string memoriaAnt, string colorAnt, string nombre, string marca, string memoria,string color, decimal precioVenta, int stock, string descripcion, string imagen)
        {
            DArticulo datos = new DArticulo();
            //Crea el objeto de la clase
            Articulo Obj = new Articulo();

            //Verificar si se modificó la combinación de identidad
            bool modificoIdentidad =
                !nombreAnt.Equals(nombre) ||
                !marcaAnt.Equals(marca) ||
                !memoriaAnt.Equals(memoria) ||
                !colorAnt.Equals(color);

            //Si se modifico algun parametro clave del producto, se verifica si ese producto ya no esta en existencia.
            if (modificoIdentidad)
            {
                string existe = datos.Existe(nombre, marca, memoria, color);
                if (existe.Equals("1"))
                {
                    return "Ya existe un artículo con el mismo nombre, marca, memoria y color.";
                }
            }

            //Continua actualizacion luego de controlar lo anterior.
            Obj.IdArticulo = id;
            Obj.IdCategoria = idCategoria;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Marca = marca;
            Obj.Memoria = memoria;
            Obj.Color = color;
            Obj.PrecioVenta = precioVenta;
            Obj.Stock = stock;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;

            return datos.Actualizar(Obj);
        }

        //Metodo para eliminar un registro que no sea de utilidad o este obsoleto
        //Devuelve una cadena con los resultados de la operacion
        public static string Eliminar(int id)
        {
            DArticulo datos = new DArticulo();

            return datos.Eliminar(id);
        }

        //Metodo para activar un registro que se encuentra desactivado
        //Devuelve una cadena con los resultados de la operacion
        public static string Activar(int id)
        {
            DArticulo datos = new DArticulo();

            return datos.Activar(id);
        }

        //Metodo para desactivar un registro
        //Devuelve una cadena con los resultados de la operacion
        public static string Desactivar(int id)
        {
            DArticulo datos = new DArticulo();

            return datos.Desactivar(id);
        }
    }
}
