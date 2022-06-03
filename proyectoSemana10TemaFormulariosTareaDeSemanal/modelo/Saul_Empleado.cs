using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.modelo
{
    class Saul_Empleado
    {
        private string NombreEmpleado;
        private string DNIempleado;
        private string DireccionEmpleado;
        private int HijosEmpleados;
        private string ExperienciaLaboralEmpleado;
        private float SueldoFijoEmpleado;

        public Saul_Empleado()
        {
            this.NombreEmpleado = "";
            this.DNIempleado = "";
            this.DireccionEmpleado = "";
            this.HijosEmpleados = 0;
            this.ExperienciaLaboralEmpleado = "";
            this.SueldoFijoEmpleado = 0;
        }

        public string NombreEmpleado1 { get => NombreEmpleado; set => NombreEmpleado = value; }
        public string DNIempleado1 { get => DNIempleado; set => DNIempleado = value; }
        public string DireccionEmpleado1 { get => DireccionEmpleado; set => DireccionEmpleado = value; }
        public int HijosEmpleados1 { get => HijosEmpleados; set => HijosEmpleados = value; }
        public string ExperienciaLaboralEmpleado1 { get => ExperienciaLaboralEmpleado; set => ExperienciaLaboralEmpleado = value; }
        public float SueldoFijoEmpleado1 { get => SueldoFijoEmpleado; set => SueldoFijoEmpleado = value; }
    }
}
