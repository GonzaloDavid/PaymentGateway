using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExperTeamTest.Entities
{
	public class Pago_Factura
	{
		public Pago_Factura()
		{
		}

        [Column("IdFactura")]
        public int IdFactura { get; set; }

        [Column("idPago")]
        public int IdPago { get; set; }

        [Column("dateCreate")]
        [DefaultValue("getdate()")]
        public DateTime DateCreate { get; set; }
    }
}

