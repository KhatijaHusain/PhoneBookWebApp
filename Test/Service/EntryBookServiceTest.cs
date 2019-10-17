using CibDigiTechWebApp.Repository;
using CibDigiTechWebApp.Service;
using FluentAssertions;
using NSubstitute;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;

namespace Test.Service
{
    public class EntryBookServiceTest
    {
        private readonly IEntryBookService _sut;
        private readonly IEntryBookRepo _entryBookRepo = Substitute.For<IEntryBookRepo>();
        
        public EntryBookServiceTest()
        {
            _sut = new EntryBookService(_entryBookRepo);
        }

        [Fact]
        public async Task GetData_ShouldReturnEntries()
        {
            var entryBook = FakeObjects.FakeObjects.GetListEntryBook();

            _entryBookRepo.GetData().Returns(entryBook);

            var result = await _sut.GetData();
            Assert.NotNull(result);
            result.Should().Equal(entryBook);
        }
        
        [Fact]
        public async Task GetDataById_ShouldReturnEntries()
        {
            var entryBook = FakeObjects.FakeObjects.GetListEntryBook();

            _entryBookRepo.GetDataById(1).Returns(entryBook);

            var result = await _sut.GetDataById(1);
            Assert.NotNull(result);
            result[0].Should().Equals(entryBook[0]);
            result[0].Should().Equals(entryBook[0].PersonName);
        }

        [Fact]
        public async Task GetDataBySearchText_ShouldReturnEntriesStartingWithSearchText()
        {
            var entryBook = FakeObjects.FakeObjects.GetListEntryBook();

            _entryBookRepo.GetDataBySearchText(1, "x").Returns(entryBook);

            var result = await _sut.GetDataBySearchText(1, "x");
            Assert.NotNull(result);
            result[0].Should().Equals(entryBook[0]);
            result.Find(x => x.PersonName.Contains("x").Equals(entryBook[0].PersonName));
        }
    }
}
