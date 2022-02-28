
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
using ProductUnluCo.Application.ValidationRules;
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
        public async Task< IActionResult >AddOfferable([FromBody] OfferableDto offerableDto)
        {

            try
            {
                OfferableValidator validator = new OfferableValidator();
                validator.ValidateAndThrow(offerableDto);
                await _offerableService.Add(offerableDto);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }

       


    }
}

