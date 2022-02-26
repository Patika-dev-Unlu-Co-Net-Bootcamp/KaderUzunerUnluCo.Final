using Business.Abstract;
using Business.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UnluCo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferablesController : ControllerBase
    {
        private IOfferableService _offerableService;

        public OfferablesController(IOfferableService offerableService)
        {
            _offerableService = offerableService;
        }

        [HttpPost]
        public IActionResult AddOfferable(OfferableDto offerableDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            _offerableService.Add(offerableDto, userId);
            return StatusCode((int)HttpStatusCode.Created);

        }

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    _offerableService.Delete(id);

        //    return Ok();
        //}

        //[HttpPut("{id}")]
        //public IActionResult Update([FromBody] OfferableDto offerable, int id)
        //{
        //    var userId = User.FindFirstValue(ClaimTypes.Name);
        //    _offerableService.Update(offerable, userId, id);
        //    return Ok();
        //}


    }
}

