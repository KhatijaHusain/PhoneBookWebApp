using CibDigiTechWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Repository
{
    public interface IEntryBookRepo
    {
        Task<List<EntryBookDto>> GetData();

        Task<List<EntryBookDto>> GetDataById(int id);

        Task<List<EntryBookDto>> GetDataBySearchText(int id, string searchText);

        Task<bool> CreateEntry(EntryBookDto entryBookDto);
    }
}
