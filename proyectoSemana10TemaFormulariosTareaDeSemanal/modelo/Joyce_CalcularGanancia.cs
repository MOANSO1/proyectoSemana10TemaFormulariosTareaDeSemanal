using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.datos
{
    class Joyce_CalcularGanancia
    {
        private string IDganancia;
        private string NombreProducto;
        private float CostoCompraProducto;
        private float CostoVentaProducto;
        private float GananciaProducto;

        public Joyce_CalcularGanancia()
        {
            this.IDganancia = "";
            this.NombreProducto = "";
            this.CostoCompraProducto = 0;
            this.CostoVentaProducto = 0;
            this.GananciaProducto = 0;
        }

        public string IDganancia1 { get => IDganancia; set => IDganancia = value; }
        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public float CostoCompraProducto1 { get => CostoCompraProducto; set => CostoCompraProducto = value; }
        public float CostoVentaProducto1 { get => CostoVentaProducto; set => CostoVentaProducto = value; }
        public float GananciaProducto1 { get => GananciaProducto; set => GananciaProducto = value; }
    }
}
