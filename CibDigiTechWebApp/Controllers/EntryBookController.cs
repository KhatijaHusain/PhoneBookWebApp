using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CibDigiTechWebApp.Model;
using CibDigiTechWebApp.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CibDigiTechWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryBookController : ControllerBase
    {
        private readonly IEntryBookService _entryBookService;

        public EntryBookController(IEntryBookService entryBookService)
        {
            _entryBookService = entryBookService;
        }

        [HttpGet]
        public async Task<ActionResult<List<EntryBookDto>>> Get()
        {
            return await _entryBookService.GetData();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<EntryBookDto>>> GetById(int id)
        {
            return await _entryBookService.GetDataById(id);
        }

        [HttpGet("{id}/{searchText}")]
        public async Task<ActionResult<List<EntryBookDto>>> GetById(int id, string searchText)
        {
            return await _entryBookService.GetDataBySearchText(id, searchText);
        }

        [HttpPost]
        public async Task<ActionResult<EntryBookDto>> Post([FromBody] EntryBookDto value)
        {
            await _entryBookService.CreateEntry(value);

            return Ok(value);
        }
    }
}