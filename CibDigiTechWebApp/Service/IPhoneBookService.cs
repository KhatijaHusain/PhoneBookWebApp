using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Service
{
    public interface IPhoneBookService
    {
        Task<List<PhoneBookDto>> GetData();

        Task<PhoneBookDto> GetDataById(int phoneBookId);

        Task CreatePhoneBook(PhoneBookDto phoneBookDto);
    }
}
