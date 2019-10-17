using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Service
{
    public interface IDirectoryService
    {
        Task<List<Directory>> GetDirectoryData();

        Task<Directory> GetDirectoryDataById(int id);

        Task CreatePhoneBook(PhoneBookDto phoneBookDto);
    }
}
