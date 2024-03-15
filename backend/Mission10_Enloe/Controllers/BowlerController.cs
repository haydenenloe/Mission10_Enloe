using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Enloe.Data;

namespace Mission10_Enloe.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private readonly IBowlingRepository _repository;

        public BowlerController(IBowlingRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BowlerDTO>> Get()
        {
            return Ok(_repository.GetBowlerDTOs());
        }
    }
}
