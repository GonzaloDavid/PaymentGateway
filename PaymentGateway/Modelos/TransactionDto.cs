using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentGateway.Modelos
{
	public class TransactionDto
	{
		public TransactionDto()
		{
		}

        public int IdTransaction { get; set; }

        public DateTime DateTransaction { get; set; }

        public decimal ValuePurchase { get; set; }

        public string NamePurchase { get; set; }

        public string Status { get; set; }

        public string StatusCat { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateLastModify { get; set; }

        public int UserCreate { get; set; }

        public int UserLastModify { get; set; }
    }
}

