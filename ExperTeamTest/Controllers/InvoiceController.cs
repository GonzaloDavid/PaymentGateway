using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ExperTeamTest.Entities;
using ExperTeamTest.Models;
using Microsoft.AspNetCore.Mvc;


namespace ExperTeamTest.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly BDDContext _db;

        private readonly IMapper _mapper;

        public InvoiceController(BDDContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [Route("api/CreateInvoice")]
        public void createInvoice(
        [FromBody] InvoiceDto invoiceContainer)
        {

            //Crear factura
            var invoiceEntity = _mapper.Map<Invoice>(invoiceContainer);

            _db.Add(invoiceEntity);
            _db.SaveChanges();

            //Crear Guia- Factura
            invoiceContainer.guiaList.ForEach(guideID =>
            {
                Guide_Invoice guide_InvoiceEntity = new Guide_Invoice();
                guide_InvoiceEntity.IdFactura = invoiceEntity.IdFactura;
                guide_InvoiceEntity.IdGuia = guideID;
                guide_InvoiceEntity.DateCreate = DateTime.Now;
                guide_InvoiceEntity.UserCreate = 1;

                _db.Add(guide_InvoiceEntity);
                
            });
            _db.SaveChanges();

            invoiceContainer.pagoList.ForEach(pagoObject =>
            {
                //Crear Pago
                var pagoEntity = _mapper.Map<Pago>(pagoObject);
                _db.Add(pagoEntity);
                _db.SaveChanges();

                //Crear Pago - Factura
                Pago_Factura pagoFacturaEntity = new Pago_Factura();
                pagoFacturaEntity.IdFactura = invoiceEntity.IdFactura;
                pagoFacturaEntity.IdPago = pagoEntity.IdPago;
                pagoFacturaEntity.DateCreate = DateTime.Now;

                _db.Add(pagoFacturaEntity);

            });
            _db.SaveChanges();

            

        }
    }
}

