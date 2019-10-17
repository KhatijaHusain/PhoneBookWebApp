using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Model;
using CibDigiTechWebApp.Repository;

namespace CibDigiTechWebApp.Service
{
    public class PhoneBookService : IPhoneBookService
    {
        private readonly IPhoneBookRepo _phoneBookRepo;

        public PhoneBookService(IPhoneBookRepo phoneBookRepo)
        {
            _phoneBookRepo = phoneBookRepo;
        }

        public Task<List<PhoneBookDto>> GetData()
        {
            return _phoneBookRepo.GetData();
        }
               
        public Task<PhoneBookDto> GetDataById(int phoneBookId)
        {
            return _phoneBookRepo.GetDataById(phoneBookId);
        }

        public async Task<bool> CreatePhoneBook(PhoneBookDto phoneBookDto)
        {
            var created = await _phoneBookRepo.CreatePhoneBook(phoneBookDto);
            return created;
        }
    }
}
