using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Mapper
{
    public static class PhoneBookMapper
    {
        public static List<Directory> Map(List<PhoneBookDto> phoneBookDto, List<EntryBookDto> entryBookDto)
        {
            List<Directory> directoryList = new List<Directory>();
            
            foreach (var phoneBook in phoneBookDto)
            {
                Directory directory = new Directory();
                List<EntryBookDto> entryBooks = new List<EntryBookDto>();
                foreach (var item in entryBookDto)
                {
                    if (item.PhoneBookId == phoneBook.PhoneBookId)
                    {
                        entryBooks.Add(item);
                    }
                }

                directory.PhoneBookId = phoneBook.PhoneBookId;
                directory.PhoneBookName = phoneBook.PhoneBookName;
                directory.Entries = entryBooks;

                directoryList.Add(directory);
            }
            return directoryList;
        }

        public static Directory MapById(PhoneBookDto phoneBookDto, List<EntryBookDto> entryBook)
        {
            Directory phoneBook = new Directory();
            List<EntryBookDto> entryBooks = new List<EntryBookDto>();
            phoneBook.PhoneBookId = phoneBookDto.PhoneBookId;
            phoneBook.PhoneBookName = phoneBookDto.PhoneBookName;
            phoneBook.Entries = entryBook;

            return phoneBook;

        }
    }
}
