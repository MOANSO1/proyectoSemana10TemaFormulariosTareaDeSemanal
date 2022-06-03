using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.datos
{
    class Conexion
    {
        SqlConnection con;
       
        public Conexion()
        {
            con = new SqlConnection("Server=MSI\\SQLEXPRESS;Database=FormSQL;integrated security=true");
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }catch (Exception em)
            {
                return null;
            }
        }

        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception em)
            {
                return false;
            }
        }
    }
}
