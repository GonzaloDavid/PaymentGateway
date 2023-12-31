﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExperTeamTest.Models
{
	public class InvoiceDto
	{
		public InvoiceDto()
		{
		}

        public int IdFactura { get; set; }

        public string Establecimiento { get; set; }

        public string PuntoEmision { get; set; }

        public int Secuencial { get; set; }

        public DateTime FechaEmision { get; set; }

        public decimal Subtotal { get; set; }

        public decimal Impuesto { get; set; }

        public decimal Total { get; set; }

        //Lista de Guia
        public List<int> guiaList { get; set; }


        //Lista de Pagos
        public List<PagoDto> pagoList { get; set; }


    }
}

