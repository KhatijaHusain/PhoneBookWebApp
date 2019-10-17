using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Model;
using CibDigiTechWebApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace CibDigiTechWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        private readonly IDirectoryService _phoneBookService;

        public DirectoryController(IDirectoryService phoneBookService)
        {
            _phoneBookService = phoneBookService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<Directory>>> Get()
        {
            return await _phoneBookService.GetDirectoryData();
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Directory>> Get(int id)
        {
            return await _phoneBookService.GetDirectoryDataById(id);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<PhoneBookDto>> Post([FromBody] PhoneBookDto value)
        {
            _phoneBookService.CreatePhoneBook(value);

            return Ok(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
