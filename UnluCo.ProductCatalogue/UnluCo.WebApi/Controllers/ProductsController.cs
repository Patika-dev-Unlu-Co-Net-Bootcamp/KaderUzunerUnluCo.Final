﻿using AutoMapper;
using Business.Abstract;
using Business.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UnluCo.Application.Dto;

namespace UnluCo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        private IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var products = await _productService.GetAll();
                return Ok(products);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    
        [HttpPost]
        public async Task <IActionResult >AddProduct([FromBody] ProductDto productDto)
        {
            try
            {
               await _productService.Add(productDto);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
          
           
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetById(id).Result;
            return Ok(product);
        }

      
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ProductDto productDelete = new ProductDto() { Id = id };
            _productService.Delete(productDelete);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ProductDto productDto)
        {
            try
            {
              
                _productService.Update(productDto);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
           
        }

     
    }
}
