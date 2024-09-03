using KRModels.Models;
using Microsoft.AspNetCore.Mvc;
using SkinAbstraction;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MModuleController : ControllerBase
    {
        private readonly IModuleAbstraction _moduleAbstraction;
        public MModuleController(IModuleAbstraction moduleAbstraction)
        {
            _moduleAbstraction = moduleAbstraction;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_moduleAbstraction.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetModuleById(Guid id)
        {
            return Ok(_moduleAbstraction.GetModuleById(id));
        }

        [HttpPost]
        public IActionResult PostModuleData([FromBody] MModule mModule)
        {
            return Ok(_moduleAbstraction.PostModuleData(mModule));
        }
        [HttpPut]
        public IActionResult PutModuleData(Guid id, [FromBody] MModule mModule)
        {
            return Ok(_moduleAbstraction.PutModuleData(id, mModule));
        }

    }
}
