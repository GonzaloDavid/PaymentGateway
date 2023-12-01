using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExperTeamTest.Entities
{
	public class Guide_Invoice
	{
		public Guide_Invoice()
		{
		}

        [Column("idGuia")]
        public int IdGuia { get; set; }

        [Column("idFactura")]
        public int IdFactura { get; set; }

        [Column("dateCreate")]
        [DefaultValue("getdate()")]
        public DateTime DateCreate { get; set; }

        [Column("userCreate")]
        public int UserCreate { get; set; }
    }
}

