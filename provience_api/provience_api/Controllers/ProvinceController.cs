using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using provience_api.Services;

namespace provience_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceService _provinceService;

        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var provinces = _provinceService.GetAll();
                return Ok(provinces);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        
    }
}
