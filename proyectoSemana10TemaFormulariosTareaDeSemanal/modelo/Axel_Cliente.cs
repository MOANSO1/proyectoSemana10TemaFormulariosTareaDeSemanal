using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal.modelo
{
    class Axel_Cliente
    {
		private string NombreCliente;
		private string ApellidosCliente;
		private string DNIcliente;
		private string TelefonoCliente;
		private string DireccionCliente;
		private string CorreoCliente;

		public Axel_Cliente()
        {
			this.NombreCliente = "";
			this.ApellidosCliente = "";
			this.DNIcliente = "";
			this.TelefonoCliente = "";
			this.DireccionCliente = "";
			this.CorreoCliente = "";
        }

		public string NombreCliente1 { get => NombreCliente; set=> NombreCliente = value; }
		public string ApellidosCliente1 { get => ApellidosCliente; set=> ApellidosCliente = value; }
		public string DNIcliente1 { get => DNIcliente; set=> DNIcliente = value; }
		public string TelefonoCliente1 { get => TelefonoCliente; set=> TelefonoCliente = value; }
		public string DireccionCliente1 { get => DireccionCliente; set=> DireccionCliente = value; }
		public string CorreoCliente1 { get => CorreoCliente; set=> CorreoCliente = value; }

	}
}
