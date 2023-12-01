using System;
namespace ExperTeamTest.Models
{
	public class PagoDto
	{
		public PagoDto()
		{
		}

        public int IdPago { get; set; }

        public string TipoPago { get; set; }

        public decimal Valor { get; set; }

    }
}

