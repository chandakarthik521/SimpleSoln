using KRModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkinAbstraction;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MLevelController : ControllerBase
    {
        private readonly ILevelAbstraction _levelAbstraction;
        public MLevelController(ILevelAbstraction levelAbstraction)
        {
            _levelAbstraction = levelAbstraction;
        }

        [HttpGet]
        public IActionResult GetLevelData()
        {
            return Ok(_levelAbstraction.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetLevelDataByID(Guid id)
        {
            return Ok(_levelAbstraction.GetLevelById(id));
        }

        [HttpPost]
        public IActionResult PostLevelData([FromBody] MLevel mLevel)
        {
            return Ok(_levelAbstraction.PostLevelData(mLevel));
        }
        [HttpPut]
        public IActionResult PutLevelData(Guid id, [FromBody] MLevel mLevel)
        {
            return Ok(_levelAbstraction.PutLevelData(id, mLevel));
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
