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
    class Axel_ClienteCAD
    {
        public static bool guardar(Axel_Cliente a)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Cliente VALUES ('" + a.NombreCliente1 + "','" + a.ApellidosCliente1 + "','" + a.DNIcliente1 + "','" + a.TelefonoCliente1 + "','" + a.DireccionCliente1 + "','" + a.CorreoCliente1 + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                con.desconectar();
                if (cantidad == 1)
                {
                    return true;
                }
                else return true;

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
                string sql = "SELECT * FROM Cliente ;";
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
