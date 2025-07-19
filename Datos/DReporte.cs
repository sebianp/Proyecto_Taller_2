using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReporte
    {
        //Método para estadisticas de ventas por periodo
        public DataTable EstadisticaVentasPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = Conexion.getInstancia().CrearConexion())
            using (SqlCommand comando = new SqlCommand("estadistica_ventas_periodo", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fechaInicio;
                comando.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fechaFin;

                conexion.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    tabla.Load(reader);
                }
            }
            return tabla;
        }

        //Método para estadisticas de TOP productos
        public DataTable EstadisticaTopProductos(DateTime fechaInicio, DateTime fechaFin, int topN = 10)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = Conexion.getInstancia().CrearConexion())
            using (SqlCommand comando = new SqlCommand("estadistica_top_productos", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fechaInicio;
                comando.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fechaFin;
                comando.Parameters.Add("@topN", SqlDbType.Int).Value = topN;

                conexion.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                    tabla.Load(reader);
            }
            return tabla;
        }

        //Metodo para ranking de vendedores por fechas.
        public DataTable EstadisticaRankingVendedores(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.getInstancia().CrearConexion())
            using (SqlCommand cmd = new SqlCommand("estadistica_ranking_vendedores", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fechaInicio;
                cmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fechaFin;

                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    tabla.Load(reader);
                }
            }
            return tabla;
        }

        // CONTROL DE STOCK

        //metodo q obtiene los productos cuyo stock está por debajo o igual al umbral.
        public DataTable EstadisticaStockCritico(int umbral)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.getInstancia().CrearConexion())
            using (SqlCommand cmd = new SqlCommand("estadistica_stock_critico", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@umbral", SqlDbType.Int).Value = umbral;

                cn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    tabla.Load(rdr);
                }
            }
            return tabla;
        }

        
        //Metodo que obtiene la distribución del stock total por categoría.
        public DataTable EstadisticaStockPorCategoria()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.getInstancia().CrearConexion())
            using (SqlCommand cmd = new SqlCommand("estadistica_stock_por_categoria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    tabla.Load(rdr);
                }
            }
            return tabla;
        }

        // Metodo que obtiene los productos sin ventas en el rango de fechas dado.
        public DataTable EstadisticaStockSinVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.getInstancia().CrearConexion())
            using (SqlCommand cmd = new SqlCommand("estadistica_stock_sin_ventas", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fechaInicio;
                cmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fechaFin;

                cn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    tabla.Load(rdr);
                }
            }
            return tabla;
        }
    }
}
