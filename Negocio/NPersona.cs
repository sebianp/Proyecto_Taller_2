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

            // Normalizo para evitar espacios
            string doc = (numDocumento ?? string.Empty).Trim();
            string correo = (email ?? string.Empty).Trim();

            //Verificar NÚMERO DE DOCUMENTO
            string existeDoc = datos.Existe(doc);
            if (existeDoc.Equals("1"))
            {
                return "Ya existe un registro con el número de documento: " + doc;
            }

            //Verificar EMAIL
            string existeMail = datos.PersonaEmailExiste(correo);
            if (existeMail.Equals("1"))
            {
                return "Ya existe un registro con ese Email.";
            }

            // 3) Crear objeto e insertar
            Persona Obj = new Persona
            {
                TipoPersona = TipoPersona,
                Nombre = nombre,
                TipoDocumento = tipoDocumento,
                NumDocumento = doc,
                Direccion = direccion,
                Telefono = telefono,
                Email = correo
            };

            return datos.Insertar(Obj);
        }

        //Metodo para actualizar un objeto existente en la base de datos
        //Devuelve una cadena los resultados de la operacion.
        public static string Actualizar(int id, string tipoPersona, string EmailAnt, string numDocAnt, string nombre, string tipoDocumento, string numDocumento, string direccion, string telefono, string email)
        {
            DPersona datos = new DPersona();

            // --- Normalizaciones para comparar ---
            string docAnterior = (numDocAnt ?? string.Empty).Trim();
            string docNuevo = (numDocumento ?? string.Empty).Trim();

            // Para comparar emails ignorando mayúsculas/minúsculas
            string emailAnteriorCmp = (EmailAnt ?? string.Empty).Trim().ToLowerInvariant();
            string emailNuevoCmp = (email ?? string.Empty).Trim().ToLowerInvariant();
            string emailFinal = (email ?? string.Empty).Trim(); // lo que se guardará

            // --- Verificación de DOCUMENTO (solo si cambió y no está vacío) ---
            if (!docAnterior.Equals(docNuevo, StringComparison.OrdinalIgnoreCase))
            {
                if (!string.IsNullOrWhiteSpace(docNuevo))
                {
                    string existeDoc = datos.Existe(docNuevo); // "1" = existe, "0" = no
                    if (existeDoc == "1")
                        return "Ya existe un registro con el DOCUMENTO: " + docNuevo;
                }
            }

            //Verificación de EMAIL
            if (!emailAnteriorCmp.Equals(emailNuevoCmp, StringComparison.Ordinal))
            {
                if (!string.IsNullOrWhiteSpace(emailNuevoCmp))
                {
                    string existeEmail = datos.PersonaEmailExiste(emailNuevoCmp); // "1" = existe, "0" = no
                    if (existeEmail == "1")
                        return "Ya existe un registro con el EMAIL: " + emailNuevoCmp;
                }
            }

            // --- Armar objeto y actualizar ---
            Persona Obj = new Persona
            {
                IdPersona = id,
                TipoPersona = tipoPersona,
                Nombre = nombre,
                TipoDocumento = tipoDocumento,
                NumDocumento = docNuevo,
                Direccion = direccion,
                Telefono = telefono,
                Email = emailFinal // guardamos el email como se ingreso normalizado.
            };

            return datos.Actualizar(Obj);
        }

        //Metodo para eliminar un registro que no sea de utilidad o este obsoleto
        //Devuelve una cadena con los resultados de la operacion
        public static string Eliminar(int id)
        {
            DPersona datos = new DPersona();

            return datos.Eliminar(id);
        }

        //Metodo para dar de baja un registro de la tabla Persona
        public static string DarDeBaja(int id)
        {
            DPersona datos = new DPersona();
            return datos.DarDeBaja(id);
        }

        //Metodo para dar de alta un registro de la tabla Persona
        public static string DarDeAlta(int id)
        {
            DPersona datos = new DPersona();
            return datos.DarDeAlta(id);
        }
    }
}
