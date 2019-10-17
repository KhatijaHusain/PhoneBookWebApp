using CibDigiTechWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Service
{
    public interface IEntryBookService
    {
        Task<List<EntryBookDto>> GetData();

        Task<List<EntryBookDto>> GetDataById(int id);

        Task<List<EntryBookDto>> GetDataBySearchText(int id, string searchText);

        Task CreateEntry(EntryBookDto entryBook);
    }
}
