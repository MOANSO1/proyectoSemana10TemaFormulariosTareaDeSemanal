using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.datos
{
    class Joyce_CalcularGananciaCAD
    {
        public static bool guardar(Joyce_CalcularGanancia j)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO GananciaProducto VALUES ('" + j.IDganancia1 + "','" + j.NombreProducto1 + "','" + j.CostoCompraProducto1 + "','" + j.CostoVentaProducto1 + "','"+j.GananciaProducto1+"')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                con.desconectar();
                if (cantidad == 1)
                {
                    return true;
                }
                else return false;

            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM GananciaProducto ;";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.desconectar();
                return dt;

            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
