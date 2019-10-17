using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CibDigiTechWebApp.Model;
using CibDigiTechWebApp.Repository;

namespace CibDigiTechWebApp.Service
{
    public class EntryBookService : IEntryBookService
    {
        private readonly IEntryBookRepo _entryBookRepo;

        public EntryBookService(IEntryBookRepo entryBookRepo)
        {
            _entryBookRepo = entryBookRepo;
        }

        public Task<List<EntryBookDto>> GetData()
        {
           return _entryBookRepo.GetData();
        }

        public Task<List<EntryBookDto>> GetDataById(int id)
        {
            return _entryBookRepo.GetDataById(id);
        }

        public Task<List<EntryBookDto>> GetDataBySearchText(int id, string searchText)
        {
            return _entryBookRepo.GetDataBySearchText(id, searchText);
        }

        public async Task<bool> CreateEntry(EntryBookDto entryBook)
        {
            return await _entryBookRepo.CreateEntry(entryBook);
        }
    }
}

