using proyectoSemana10TemaFormulariosTareaDeSemanal.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace proyectoSemana10TemaFormulariosTareaDeSemanal
{
    internal class DicarloCAD
    {
       public static bool guardarVenta(VentaProducto e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO ComprarProductos VALUES('"+e.IDcompra1+"', '"+e.DNIcliente1+"', '"+e.DNIempleado1+"', '"+e.CostoTotal1+"')";
                SqlCommand comando = new SqlCommand(sql,con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else return false;
                con.desconectar();
            }catch(Exception em)
            {
                return false;
            }
        }
        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * from ComprarProductos;";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.desconectar();
                return dt;



            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
