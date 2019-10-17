using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CibDigiTechWebApp.DbContexts;
using CibDigiTechWebApp.Model;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace CibDigiTechWebApp.Repository
{
    public class EntryBookRepo : IEntryBookRepo
    {
        private readonly PhoneBookDBContext _dbContext;

        public EntryBookRepo(PhoneBookDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<EntryBookDto>> GetData()
        {
            return _dbContext.EntryBook.ToListAsync();
        }

        public Task<List<EntryBookDto>> GetDataById(int id)
        {
            return _dbContext.EntryBook.Where(x => x.PhoneBookId == id).ToListAsync();

        }

        public Task<List<EntryBookDto>> GetDataBySearchText(int id, string searchText)
        {
            if (searchText != null)
                return _dbContext.EntryBook.Where(x => x.PhoneBookId == id && x.PersonName.ToLower().Contains(searchText.ToLower())).ToListAsync();
            else
                return null;
        }

        public Task CreateEntry(EntryBookDto entryBookDto)
        {
            _dbContext.Add(entryBookDto);
            return _dbContext.SaveChangesAsync();
        }

    }
}
