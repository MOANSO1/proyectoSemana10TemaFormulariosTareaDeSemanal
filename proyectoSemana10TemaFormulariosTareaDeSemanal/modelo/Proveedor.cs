using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.modelo
{
    internal class Proveedor
    {
        private string NombreProveedor;
        private string IDproveedor;
        private string TelefonoProveedor;
        private string CorreoCliente;

        public Proveedor()
        {
            this.NombreProveedor = "";
            this.IDproveedor = "";
            this.TelefonoProveedor = "";
            this.CorreoCliente = "";
        }

        public string NombreProveedor1 { get => NombreProveedor; set => NombreProveedor = value; }
        public string IDproveedor1 { get => IDproveedor; set => IDproveedor = value; }
        public string TelefonoProveedor1 { get => TelefonoProveedor; set => TelefonoProveedor = value; }
        public string CorreoCliente1 { get => CorreoCliente; set => CorreoCliente = value; }
    }
}
