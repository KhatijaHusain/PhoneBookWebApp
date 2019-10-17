using CibDigiTechWebApp.DbContexts;
using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CibDigiTechWebApp.Repository
{
    public class PhoneBookRepo : IPhoneBookRepo
    {
        private readonly PhoneBookDBContext _dbContext;

        public PhoneBookRepo(PhoneBookDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<PhoneBookDto>> GetData()
        {
            return _dbContext.PhoneBookDto.ToListAsync();
            
        }

        public Task<PhoneBookDto> GetDataById(int phoneBookId)
        {
            return _dbContext.PhoneBookDto.FindAsync(phoneBookId);
        }

        public async Task CreatePhoneBook(PhoneBookDto phoneBookDto)
        {
             _dbContext.PhoneBookDto.Add(phoneBookDto);
            await _dbContext.SaveChangesAsync();
        }
    }
}
