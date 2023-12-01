using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExperTeamTest.Entities
{
	public class Guide
	{
		public Guide()
		{
		}


        [Column("idGuia")]
        public int IdGuia { get; set; }

        [Column("numeroGuia")]
        public string NumeroGuia { get; set; }

        [Column("fechaEnvio")]
        public  DateTime FechaEnvio { get; set; }

        [Column("paisOrigen")]
        public string PaisOrigen { get; set; }

        [Column("nombreRemitente")]
        public string NombreRemitente { get; set; }

        [Column("direccionRemitente")]
        public string DireccionRemitente { get; set; }

        [Column("telefonoRemitente")]
        public string TelefonoRemitente { get; set; }

        [Column("emailRemitente")]
        public string EmailRemitente { get; set; }

        [Column("paisDestino")]
        public string PaisDestino { get; set; }

        [Column("nombreDestinatario")]
        public string NombreDestinatario { get; set; }

        [Column("direccionDestinatario")]
        public string DireccionDestinatario { get; set; }

        [Column("telefonoDestinatario")]
        public string TelefonoDestinatario { get; set; }

        [Column("emailDestinatario")]
        public string EmailDestinatario { get; set; }

        [Column("total")]
        public Decimal Total { get; set; }


    }
}

