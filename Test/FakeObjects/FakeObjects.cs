using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.FakeObjects
{
    public static class FakeObjects
    {
        public static PhoneBookDto GetPhoneBook() => new PhoneBookDto
        {
            PhoneBookId = 1,
            PhoneBookName = "Home"
        };

        public static EntryBookDto GetEntryBook() => new EntryBookDto
        {
            PersonId = 1,
            PersonName = "XYZ",
            PhoneBookId = 1,
            PhoneNo = 131244
        };

        public static List<PhoneBookDto> GetListPhoneBook() => new List<PhoneBookDto>()
        {
            new PhoneBookDto
            {
                PhoneBookId = 1,
                PhoneBookName = "Work"
            },
            new PhoneBookDto
            {
                PhoneBookId = 2,
                PhoneBookName = "Home"
            },
        };
        
        public static List<EntryBookDto> GetListEntryBook() => new List<EntryBookDto>()
        {
            new EntryBookDto
            {
                PersonId = 1,
                PersonName = "XYZ",
                PhoneBookId = 1,
                PhoneNo = 131244
            },
            new EntryBookDto
            {
                PersonId = 2,
                PersonName = "abc",
                PhoneBookId = 1,
                PhoneNo = 131244
            }
        };
    }
}
