using CibDigiTechWebApp.Dto;
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
        public async Task<ActionResult<PhoneBookDto>> Post([FromBody] PhoneBookDto value)
        {
            await _phoneBookService.CreatePhoneBook(value);

            return Ok(value);
        }
    }
}
