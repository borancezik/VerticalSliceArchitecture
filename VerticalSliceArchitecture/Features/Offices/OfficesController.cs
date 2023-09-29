using Microsoft.AspNetCore.Mvc;

namespace VerticalSliceArchitecture.Features.Offices
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        private readonly IOfficeService _officeService;

        public OfficesController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _officeService.GetById(id);
            return Ok(result);  
        }
    }
}
