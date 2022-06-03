using proyectoSemana10TemaFormulariosTareaDeSemanal.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.datos
{
    class Saul_EmpleadoCAD
    {
        public static bool guardar(Saul_Empleado s)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Empleado VALUES ('"+s.NombreEmpleado1+"','"+s.DNIempleado1+"','"+s.DireccionEmpleado1+"','"+s.HijosEmpleados1+"','"+s.ExperienciaLaboralEmpleado1+"','"+s.SueldoFijoEmpleado1+"')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                con.desconectar();
                if (cantidad == 1)
                {
                    return true;
                }
                else return true;

            }catch(Exception e)
            {
                return false;
            }
        }
    }
}
