using KRModels.Models;
using Microsoft.AspNetCore.Mvc;
using SkinAbstraction;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MSkinController : ControllerBase
    {
        private readonly SkinAbstraction.ISkinAbstraction _skinAbstraction;
        public MSkinController(SkinAbstraction.ISkinAbstraction skinAbstraction)
        {
            _skinAbstraction = skinAbstraction;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_skinAbstraction.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetID(Guid id)
        {
            return Ok(_skinAbstraction.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] MSkin mSkin)
        {
            return Ok(_skinAbstraction.Post(mSkin));
        }
        [HttpPut]
        public IActionResult Put(Guid id, [FromBody] MSkin value)
        {
            return Ok(_skinAbstraction.Put(id, value));
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}
