using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaymentGateway.Entities;
using PaymentGateway.Mappers;
using PaymentGateway.Modelos;



namespace PaymentGateway.Controllers
{
    public class TransactionController : Controller
    {

        private readonly BDDContext _db;

        private readonly IMapper _mapper;

        public TransactionController(BDDContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [Route("api/CreateTransaction")] 
        public List<TransactionModel> CreateTransaction(
            [FromBody]  TransactionDto reqEncriptado)
        {
            GenericResponse response = new GenericResponse();
            response.Code = 200;
            response.Description = "Hola mundo";

            var idSearch = 1l;

            var session =  _db.TTransaction
            .Where(p => (p.IdTransaction) == idSearch)
            .ToList();

            //var destinationObject = Mapper.Map<TransactionModel>(reqEncriptado);
            var entity = _mapper.Map<TransactionModel>(reqEncriptado);

            _db.Add(entity);
            _db.SaveChanges();

            return session;
        }
    }

}

//jdbc: sqlserver://;serverName=localhost;databaseName=master