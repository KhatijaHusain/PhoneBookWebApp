﻿using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookController : ControllerBase
    {
        private readonly IPhoneBookService _phoneBookService;

        public PhoneBookController(IPhoneBookService phoneBookService)
        {
            _phoneBookService = phoneBookService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PhoneBookDto>>> Get()
        {
            return await _phoneBookService.GetData();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PhoneBookDto>> GetById(int id)
        {
            return await _phoneBookService.GetDataById(id);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<PhoneBookDto>> Post([FromBody] PhoneBookDto value)
        {
            var created = await _phoneBookService.CreatePhoneBook(value);
           if (created)
                return Ok(value);
            return BadRequest("Either Duplicate primary key added or no phone book name");
        }
    }
}
