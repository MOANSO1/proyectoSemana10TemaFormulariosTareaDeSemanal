using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal
{
    internal class VentaProducto
    {
    private string IDcompra;
    private string DNIcliente;
    private string CostoTotal;
    private string DNIempleado;

        public VentaProducto()
        {
            this.IDcompra = "";
            this.DNIcliente = "";
            this.CostoTotal = "";
            this.DNIempleado = "";
        }

        public string IDcompra1 { get => IDcompra; set => IDcompra = value; }
        public string DNIcliente1 { get => DNIcliente; set => DNIcliente = value; }
        public string CostoTotal1 { get => CostoTotal; set => CostoTotal = value; }
        public string DNIempleado1 { get => DNIempleado; set => DNIempleado = value; }
    }
}
