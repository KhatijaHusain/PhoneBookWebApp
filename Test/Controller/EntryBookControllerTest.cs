using CibDigiTechWebApp.Controllers;
using CibDigiTechWebApp.Service;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Test.Controller
{
    public class EntryBookControllerTest
    {
        private readonly EntryBookController _sut;
        private readonly IEntryBookService _entryBookService = Substitute.For<IEntryBookService>();

        public EntryBookControllerTest()
        {
            _sut = new EntryBookController(_entryBookService);
        }

        [Fact]
        public async Task Get_ShouldReturnEntryBook()
        {
            var entryBook = FakeObjects.FakeObjects.GetListEntryBook();
            _entryBookService.GetData().Returns(entryBook);
            var actionResult = await _sut.Get();
            actionResult.Value.Equals(entryBook);

        }

        [Fact]
        public async Task GetById_ShouldReturnEntryBook()
        {
            var entryBook = FakeObjects.FakeObjects.GetListEntryBook();
            _entryBookService.GetDataById(1).Returns(entryBook);
            var actionResult = await _sut.GetById(1);
            actionResult.Value.Find(x => x.PhoneBookId == 1).Equals(entryBook);
        }

        [Fact]
        public async Task GetBySearchText_ShouldReturnEntryBook()
        {
            var entryBook = FakeObjects.FakeObjects.GetListEntryBook();
            _entryBookService.GetDataBySearchText(1, "X").Returns(entryBook.FindAll(x => x.PersonName.Contains("x")));
            var actionResult = await _sut.GetById(1, "X");
            actionResult.Value.Equals(entryBook.FindAll(x => x.PersonName.Contains("x")));
        }

        [Fact]
        public async Task Create_ShouldReturnOK()
        {
            var entryBook = FakeObjects.FakeObjects.GetListEntryBook();
            await _entryBookService.CreateEntry(entryBook[0]);
            var actionResult = await _sut.Post(entryBook[0]);
            actionResult.Result.Equals(typeof(OkObjectResult));
        }
    }
}
