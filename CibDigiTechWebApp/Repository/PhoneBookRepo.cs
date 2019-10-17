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

        public async Task<bool> CreatePhoneBook(PhoneBookDto phoneBookDto)
        {
            await _dbContext.PhoneBookDto.AddAsync(phoneBookDto);
            int phoneEntry = await _dbContext.SaveChangesAsync();

            if (phoneEntry != 0)
                return true;
            return false;
        }
    }
}
