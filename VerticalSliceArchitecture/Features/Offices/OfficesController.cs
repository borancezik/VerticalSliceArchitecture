using Microsoft.AspNetCore.Mvc;
using VerticalSliceArchitecture.Features.Offices.Abstract;
using VerticalSliceArchitecture.Features.Offices.Models;

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

            if (result == null)
            {
                return BadRequest(result);
            }

            return Ok(result);  
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _officeService.GetAll();

            if (result == null)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut]
        public IActionResult Add(OfficeEntity officeEntity)
        {
            var result = _officeService.Add(officeEntity);

            if (result == null)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Update(OfficeEntity officeEntity)
        {
            var result = _officeService.Update(officeEntity);

            if (result == null)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(OfficeEntity officeEntity)
        {
            var result = _officeService.Delete(officeEntity);

            if (result == null)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
