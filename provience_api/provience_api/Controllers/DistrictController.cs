using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using provience_api.Services;

namespace provience_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _districtService;

        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var districts = _districtService.GetAll();
                return Ok(districts);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{provinceCode}")]
        public IActionResult GetByProvinceCode(string provinceCode)
        {
            try
            {
                var dataDistrict = _districtService.GetByProvinceCode(provinceCode);
                if (dataDistrict != null)
                {
                    return Ok(dataDistrict);
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
