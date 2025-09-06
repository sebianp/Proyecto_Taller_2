using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReporte
    {
        //Método para mostrar las ventas por periodo
        public static DataTable EstadisticaVentasPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            DReporte datos = new DReporte();
            return datos.EstadisticaVentasPeriodo(fechaInicio, fechaFin);
        }
        
        //Método para mostrar top articulos por ventas y fecha
        public static DataTable EstadisticaTopProductos(DateTime fechaInicio, DateTime fechaFin, int topN, int? idCategoria)
        {
            DReporte datos = new DReporte();
            return datos.EstadisticaTopProductos(fechaInicio, fechaFin, topN, idCategoria);
        }

        //Metodo para ranking de vendedores por fecha
        public static DataTable EstadisticaRankingVendedores(DateTime fechaInicio, DateTime fechaFin)
        {
            DReporte datos = new DReporte();
            return datos.EstadisticaRankingVendedores(fechaInicio, fechaFin);
        }

        //Métodos de CONTROL DE STOCK

        // Metodo que devuelve los artículos con stock igual o inferior al umbral.
        public static DataTable EstadisticaStockCritico(int umbral, int? IdCategoria)
        {
            DReporte datos = new DReporte();
            return datos.EstadisticaStockCritico(umbral, IdCategoria);
        }

        //metodo que devuelve la suma de stock por cada categoría.
        public static DataTable EstadisticaStockPorCategoria()
        {
            DReporte datos = new DReporte();
            return datos.EstadisticaStockPorCategoria();
        }

        //Metodo que devuelve los artículos sin ventas aceptadas en el rango de fechas previsto.
        public static DataTable EstadisticaStockSinVentas(DateTime fechaInicio, DateTime fechaFin, int IdCategoria)
        {
            DReporte datos = new DReporte();
            return datos.EstadisticaStockSinVentas(fechaInicio, fechaFin, IdCategoria);
        }
    }
}
