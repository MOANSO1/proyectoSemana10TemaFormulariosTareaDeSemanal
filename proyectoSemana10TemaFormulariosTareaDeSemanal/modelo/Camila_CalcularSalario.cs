using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.modelo
{
    class Camila_CalcularSalario
    {
        private string IDsalario;
        private string NombreTrabajador;
        private float SalarioFijo;
        private float ComisionPorVenta;
        private int CantidadVentas;
        private float SalarioTotal;

        public Camila_CalcularSalario()
        {
            this.IDsalario = "";
            this.NombreTrabajador = "";
            this.SalarioFijo = 0;
            this.ComisionPorVenta = 0;
            this.CantidadVentas = 0;
            this.SalarioTotal = 0;
        }

        public string IDsalario1 { get => IDsalario; set=> IDsalario = value; }
        public string NombreTrabajador1 { get => NombreTrabajador; set=> NombreTrabajador = value; }
        public float SalarioFijo1 { get => SalarioFijo; set=> SalarioFijo = value; }
        public float ComisionPorVenta1 { get => ComisionPorVenta; set=> ComisionPorVenta = value; }
        public int CantidadVentas1 { get => CantidadVentas; set=> CantidadVentas = value; }
        public float SalarioTotal1 { get => SalarioTotal; set=> SalarioTotal = value; }
    }
}
