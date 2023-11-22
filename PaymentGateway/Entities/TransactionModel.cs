using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace PaymentGateway.Modelos
{
	public class TransactionModel
	{
		public TransactionModel()
		{
			NamePurchase = "";

        }


        [Column("idTransaction")]
        public long IdTransaction { get; set; }

        [Column("dateTransaction")]
        public DateTime DateTransaction { get; set; }

        [Column("valuePurchase")]
        public decimal ValuePurchase { get; set;  }

        [Column("namePurchase")]
        public string NamePurchase { get; set;  }

        [Column("status")]
        public string Status { get; set;  }

        [Column("statusCat")]
        public string StatusCat { get;set;  }

        [Column("dateCreate")]
        [DefaultValue("getdate()")]
        public DateTime DateCreate { get; set; }

        [Column("dateLastModify")]
        [DefaultValue("getdate()")]
        public DateTime DateLastModify { get; set; }

        [Column("userCreate")]
        public long UserCreate { get; set; }

        [Column("userLastModify")]
        public long UserLastModify { get; set; }
    }
}

