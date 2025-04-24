using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRol
    {
        //Metodo para listar todos los registros
        //devuelve un objeto del tipo DataTable
        public static DataTable Listar()
        {
            //Instanciamos un objeto de la clase
            DRol datos = new DRol();
            //Devolvemos el metodo Listar de la clase
            return datos.Listar();

        }
    }
}
