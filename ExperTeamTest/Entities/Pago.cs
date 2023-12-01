using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExperTeamTest.Entities
{
	public class Pago
	{
		public Pago()
		{
		}

        [Column("idPago")]
        public int IdPago { get; set; }

        [Column("tipoPago")]
        public string tipoPago { get; set; }

        [Column("valor")]
        public Decimal valor { get; set; }

        
    }
}

