using CibDigiTechWebApp.Controllers;
using CibDigiTechWebApp.Service;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test.Controller
{
    public class PhoneBookControllertTest
    {
        private readonly PhoneBookController _sut;
        private readonly IPhoneBookService _phoneBookService = Substitute.For<IPhoneBookService>();

        public PhoneBookControllertTest()
        {
            _sut = new PhoneBookController(_phoneBookService);
        }

        [Fact]
        public async Task Get_ShouldReturnPhoneBook()
        {
            var PhoneBook = FakeObjects.FakeObjects.GetListPhoneBook();
            _phoneBookService.GetData().Returns(PhoneBook);
            var actionResult = await _sut.Get();
            actionResult.Value.Equals(PhoneBook);

        }

        [Fact]
        public async Task GetById_ShouldReturnPhoneBook()
        {
            var phoneBook = FakeObjects.FakeObjects.GetListPhoneBook();
            _phoneBookService.GetDataById(1).Returns(phoneBook.Find(x => x.PhoneBookId == 1));
            var actionResult = await _sut.GetById(1);
            actionResult.Value.Equals(phoneBook.Find(x => x.PhoneBookId == 1));
        }

        [Fact]
        public async Task Create_ShouldReturnOK()
        {
            var PhoneBook = FakeObjects.FakeObjects.GetListPhoneBook();
            await _phoneBookService.CreatePhoneBook(PhoneBook[0]);
            var actionResult = await _sut.Post(PhoneBook[0]);
            actionResult.Result.Equals(typeof(OkObjectResult));
        }
    }
}
