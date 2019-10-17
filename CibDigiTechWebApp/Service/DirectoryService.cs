using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Mapper;
using CibDigiTechWebApp.Model;

namespace CibDigiTechWebApp.Service
{
    public class DirectoryService : IDirectoryService
    {
        private readonly IPhoneBookService _phoneBookService;
        private readonly IEntryBookService _entryBookService;

        public DirectoryService(IPhoneBookService phoneBookService, IEntryBookService entryBookService)
        {
            _phoneBookService = phoneBookService;
            _entryBookService = entryBookService;
        }

        public async Task<List<Directory>> GetDirectoryData()
        {
            var phoneBook = await _phoneBookService.GetData();
            var entryBook = await _entryBookService.GetData();
            return PhoneBookMapper.Map(phoneBook, entryBook);

        }

        public async Task<Directory> GetDirectoryDataById(int id)
        {
            var phoneBook = await _phoneBookService.GetDataById(id);
            var entryBook = await _entryBookService.GetDataById(id);
            return PhoneBookMapper.MapById(phoneBook, entryBook);
        }

        public async Task CreatePhoneBook(PhoneBookDto phoneBookDto)
        {
            await _phoneBookService.CreatePhoneBook(phoneBookDto);
        }
    }
        
}
