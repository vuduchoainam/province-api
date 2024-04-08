using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using provience_api.Services;

namespace provience_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardController : ControllerBase
    {
        private readonly IWardService _wardService;

        public WardController(IWardService wardService)
        {
            _wardService = wardService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var wards = _wardService.GetAll();
                return Ok(wards);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{districtCode}")]
        public IActionResult GetByProvinceCode(string districtCode)
        {
            try
            {
                var dataWard = _wardService.GetByDistrictCode(districtCode);
                if (dataWard != null)
                {
                    return Ok(dataWard);
                }
                return NotFound();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
    
}
