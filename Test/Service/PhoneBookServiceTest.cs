using CibDigiTechWebApp.Repository;
using CibDigiTechWebApp.Service;
using FluentAssertions;
using NSubstitute;
using System.Threading.Tasks;
using Xunit;

namespace Test.Service
{
    public class PhoneBookServiceTest
    {
        private readonly IPhoneBookService _sut;
        private readonly IPhoneBookRepo _phoneBookRepo = Substitute.For<IPhoneBookRepo>();

        public PhoneBookServiceTest()
        {
            _sut = new PhoneBookService(_phoneBookRepo);
        }

        [Fact]
        public async Task GetData_ShouldReturnPhoneBooks()
        {
            var phoneBook = FakeObjects.FakeObjects.GetListPhoneBook();

            _phoneBookRepo.GetData().Returns(phoneBook);

            var result = await _sut.GetData();
            Assert.NotNull(result);
            result.Should().Equal(phoneBook);
        }

        [Fact]
        public async Task GetDataById_ShouldReturnPhoneBook()
        {
            var phoneBook = FakeObjects.FakeObjects.GetPhoneBook();

            _phoneBookRepo.GetDataById(1).Returns(phoneBook);

            var result = await _sut.GetDataById(1);
            Assert.NotNull(result);
            result.Should().Equals(phoneBook);
        }
    }
}
