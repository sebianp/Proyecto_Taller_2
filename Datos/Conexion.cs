using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Para trabajar con base de datos SQL

namespace Datos
{
    public class Conexion
    {
        private string Base; //Nombre de la base de datos a la que nos vamos a conectar
        private string Servidor; //Nombre del servidor dentro de la base de datos al que nos vamos a conectar
        private string Usuario; //Nombre del usuario para establecer la conexion con la base de datos
        private string Clave; //La cadena de caracteres que representa la clave para ingresar con el usuario
        private bool Seguridad; // De que manera utilizo la seguridad, con autenticacion de windows o no

        //Se crea un objeto que instancie a la clase conexion
        private static Conexion Con = null;

        //Constructor de la clase conexion, se declara privado para que no se pueda instanciar en otra clase
        // Mas abajo se declara un metodo que instancia al constructor
        private Conexion()
        {
            //Ingresamos los valores a cada una de las propiedades
            //IMPORTANTE: Acá de debe gestionar la conexion a la base de datos, colocar los datos adecuados
            this.Base = "db_libertel"; //Nombre de la base de datos
            this.Servidor = "INTERCEPTOR02-S"; //Nombre servidor -> Importante, si lleva slash (\) se pone doble slash
            this.Usuario = "sa"; //Nombre de usuario para conexion sin autenticacion de windows
            this.Clave = "12345"; //Contraseña del usuario para la conexion
            this.Seguridad = true; //Colocar true para iniciar con autenticacion de windows
        }

        //Creamos la conexion con la base de datos
        // Retorna la variable SqlConnection con la cadena de conexion armada
        public SqlConnection CrearConexion()
        {
            //Instanciamos un objeto de SqlConnection para generar la cadena de conexion con la DB
            SqlConnection Cadena = new SqlConnection();

            try
            {
                // ConnectionString es un metodo que hereda de la clase SqlConnection para indicar
                // cual sera la cadena de conexion
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";

                //Construimos la ultima parte de la cadena segun la seguridad de la conexion
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else 
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id ="+this.Usuario+"; Password="+this.Clave;
                }
            }
            catch (Exception ex)
            {
                //En caso de que algo falle, la cadena queda vacía y se lanza el mensaje de ex
                Cadena = null;
                throw ex;
            }

            //Retornamos la variable del tipo SqlConnection que sería la cadena de conexion.
            return Cadena;
        }

        //METODO QUE ME PERMITE CREAR LA INSTANCIA DE CONEXION
        public static Conexion getInstancia()
        {
            //Verifico si no tengo una instancia antes de crearla
            if(Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
