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
            //Normalizacion
            string correo = (email ?? string.Empty).Trim();
            string doc = (numDocumento ?? string.Empty).Trim();

            //Validacion de EMAIL
            string existeEmail = datos.Existe(correo); // "1" = existe, "0" = no
            if (existeEmail.Equals("1"))
            {
                return "El usuario con ese Email ya existe";
            }

            //Validación de NUMERO DE DOCUMENTO
            string existeDoc = datos.ExisteNumDocumento(doc); // "1" = existe, "0" = no
            if (existeDoc.Equals("1"))
            {
                return "El usuario con ese Número de Documento ya existe";
            }

            // 3) Crear objeto y continuar con la inserción
            Usuario Obj = new Usuario
            {
                IdRol = idRol,
                Nombre = nombre,
                TipoDocumento = tipoDocumento,
                NumDocumento = doc,
                Direccion = direccion,
                Telefono = telefono,
                Email = correo,
                Clave = clave
            };

            return datos.Insertar(Obj);
        }

        //Metodo para actualizar un objeto existente en la base de datos
        //Devuelve una cadena los resultados de la operacion.
        public static string Actualizar(int id, int idRol, string nombre, string tipoDocumento, string NumDocAnterior, string numDocumento, string direccion, string telefono, string emailAnt, string email, string clave)
        {
            DUsuario datos = new DUsuario();

            //Normalizar valores para guardado
            string docAnterior = (NumDocAnterior ?? string.Empty).Trim();
            string docNuevo = (numDocumento ?? string.Empty).Trim();

            string emailAntCmp = (emailAnt ?? string.Empty).Trim().ToLowerInvariant();
            string emailNuevo = (email ?? string.Empty).Trim();
            string emailNuevoCmp = emailNuevo.ToLowerInvariant();

            //Verificación de DOCUMENTO, solo si se cambio
            if (!docAnterior.Equals(docNuevo, StringComparison.OrdinalIgnoreCase))
            {
                if (!string.IsNullOrWhiteSpace(docNuevo))
                {
                    string existeDoc = datos.ExisteNumDocumento(docNuevo); // "1" = existe
                    if (existeDoc.Equals("1"))
                        return "El usuario con el Número de Documento: "+ docNuevo +" ya existe";
                }
            }

            // --- Verificación de EMAIL (solo si cambió) ---
            if (!emailAntCmp.Equals(emailNuevoCmp, StringComparison.Ordinal))
            {
                if (!string.IsNullOrWhiteSpace(emailNuevoCmp))
                {
                    string existeEmail = datos.Existe(emailNuevoCmp); // "1" = existe
                    if (existeEmail.Equals("1"))
                        return "El usuario con eel Email: "+ emailNuevoCmp + " ya existe";
                }
            }

            // --- Construcción del objeto y actualización ---
            Usuario Obj = new Usuario
            {
                IdUsuario = id,
                IdRol = idRol,
                Nombre = nombre,
                TipoDocumento = tipoDocumento,
                NumDocumento = docNuevo,
                Direccion = direccion,
                Telefono = telefono,
                Email = emailNuevo, //Se guarda con el formato ingresado
                Clave = clave
            };

            return datos.Actualizar(Obj);
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
