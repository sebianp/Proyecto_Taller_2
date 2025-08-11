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
    public class NVenta
    {
        public static DataTable Listar()
        {
            DVenta Datos = new DVenta();
            return Datos.Listar();
        }

        public static DataTable ListarVentasVendedor(int idusuario)
        {
            DVenta Datos = new DVenta();
            return Datos.ListarVentasVendedor(idusuario);
        }

        public static DataTable Buscar(string Valor, int IdUsuario)
        {
            DVenta Datos = new DVenta();
            return Datos.Buscar(Valor, IdUsuario);
        }

        //Obtiene el ultimo valor del comprobante que debe agregarse,
        public static string ObtenerSiguienteNumeroVenta()
        {
            return new DVenta().VentaSiguienteNumero();
        }

        public static DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            DVenta Datos = new DVenta();
            return Datos.ConsultaFechas(FechaInicio,FechaFin);
        }

        public static DataTable ConsultaVentasFechasUsuario(DateTime fecha_inicio, DateTime fecha_fin, int idUsuario)
        {
            DVenta Datos = new DVenta();
            return Datos.ConsultaVentasFechasUsuario(fecha_inicio, fecha_fin, idUsuario);
        }

        public static DataTable ListarDetalle(int Id)
        {
            DVenta Datos = new DVenta();
            return Datos.ListarDetalle(Id);
        }

        public static string Insertar(int IdCliente, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            DVenta Datos = new DVenta();
            Venta Obj = new Venta(); //Definido en Entidades

            //Agrego los datos al objeto
            Obj.IdCliente = IdCliente;
            Obj.IdUsuario = IdUsuario;
            Obj.TipoComprobante = TipoComprobante;
            Obj.SerieComprobante = SerieComprobante;
            Obj.NumComprobante = NumComprobante;
            Obj.Impuesto = Impuesto;
            Obj.Total = Total;
            Obj.Detalles = Detalles;

            return Datos.Insertar(Obj);
        }

        public static string Anular(int Id)
        {
            DVenta Datos = new DVenta();
            return Datos.Anular(Id);
        }
    }
}
