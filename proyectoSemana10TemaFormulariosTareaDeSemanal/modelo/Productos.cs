using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.modelo
{
    internal class Productos
    {
        private string IDproducto;
        private string IDproveedor;
        private string NombreProducto;
        private float PrecioProducto;

        public Productos()
        {
            this.IDproducto = "";
            this.IDproveedor = "";
            this.NombreProducto = "";
            this.PrecioProducto = 0;
        }

        public string IDproducto1 { get => IDproducto; set => IDproducto = value; }
        public string IDproveedor1 { get => IDproveedor; set => IDproveedor = value; }
        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public float PrecioProducto1 { get => PrecioProducto; set => PrecioProducto = value; }
    }
}
