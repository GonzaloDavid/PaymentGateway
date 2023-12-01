using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExperTeamTest.Entities
{
	public class Invoice
	{
		public Invoice()
		{
		}

        [Column("idFactura")]
        public int IdFactura { get; set; }

        [Column("establecimiento")]
        public string Establecimiento { get; set; }

        [Column("puntoEmision")]
        public string PuntoEmision { get; set; }

        [Column("secuencial")]
        public int Secuencial { get; set; }

        [Column("fechaEmision")]
        public DateTime FechaEmision { get; set; }

        [Column("subtotal")]
        public Decimal Subtotal { get; set; }

        [Column("impuesto")]
        public Decimal Impuesto { get; set; }

        [Column("total")]
        public Decimal Total { get; set; }
        


    }
}

