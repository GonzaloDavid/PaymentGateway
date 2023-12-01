using AutoMapper;
using ExperTeamTest.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace Application
{
    public class GuideController : Controller
    {

        private readonly BDDContext _db;

        private readonly IMapper _mapper;

        public GuideController(BDDContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [Route("api/CreateGuide")]
        public Guide createGuide(
        [FromBody] Guide guideEntity)
        {

            //var entity = _mapper.Map<Guide>(guideEntity);

            _db.Add(guideEntity);
            _db.SaveChanges();

            return guideEntity;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [Route("api/getAll")]
        public List<Guide> getAllGuides()
        {

            var guideBDD = _db.Guide
            .ToList();

            return guideBDD;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [Route("api/getGuideById")]
        public List<Guide> getTransactionById(
         [FromQuery] int idGuide)
        {

            var idSearch = idGuide;

            var guideBDD = _db.Guide
            .Where(p => (p.IdGuia) == idSearch)
            .ToList();

            return guideBDD;
        }
    }
}

