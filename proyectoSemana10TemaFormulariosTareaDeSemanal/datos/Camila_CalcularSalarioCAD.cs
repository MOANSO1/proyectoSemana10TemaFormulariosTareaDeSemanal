using proyectoSemana10TemaFormulariosTareaDeSemanal.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.datos
{
    class Camila_CalcularSalarioCAD
    {
        public static bool guardar(Camila_CalcularSalario c)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO SalarioTrabajador VALUES ('" + c.IDsalario1 + "','" + c.NombreTrabajador1 + "','"+c.SalarioFijo1+"','" + c.ComisionPorVenta1 + "','" + c.CantidadVentas1 + "','"+c.SalarioTotal1+ "')";
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
                string sql = "SELECT * FROM SalarioTrabajador ;";
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
