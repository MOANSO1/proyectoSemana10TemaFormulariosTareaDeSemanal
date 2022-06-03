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
    internal class ProductosMCAD
    {
        public static bool guardar(Productos p)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Producto VALUES('" + p.IDproducto1 + "', '" + p.IDproveedor1 + "', '" + p.NombreProducto1 + "', '" + p.PrecioProducto1+ "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                con.desconectar();
                if (cantidad == 1)
                {
                    return true;
                }
                else return false;
                
            }
            catch (Exception em)
            {
                return false;
            }
        }

        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM Producto ;";
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

