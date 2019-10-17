using CibDigiTechWebApp.DbContexts;
using CibDigiTechWebApp.Repository;
using CibDigiTechWebApp.Service;
using NSubstitute;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using CibDigiTechWebApp.Model;
using System.Collections.Generic;

namespace Test.Repo
{
    public class EntryBookRepoTests
    {
        private readonly IEntryBookRepo _entryBookRepo = Substitute.For<IEntryBookRepo>();
        private readonly IEntryBookService _entryBookService = Substitute.For<IEntryBookService>();

        [Fact]
        public async Task GetById_ReturnEntryBook()
        {
            using (var context = new PhoneBookDBContext(GetOptions("EntryBookTest1")))
            {
                var entryBook = FakeObjects.FakeObjects.GetEntryBook();
                context.EntryBook.Add(entryBook);
                context.SaveChanges();

                var sut = new EntryBookRepo(context);
                List<EntryBookDto> result = await sut.GetDataById(entryBook.PhoneBookId);
                Assert.NotNull(result);
                result[0].PersonName.Should().Equals("XYZ");
            }
        }

        [Fact]
        public async Task GetDataBySearchText_ReturnEntryBook()
        {
            using (var context = new PhoneBookDBContext(GetOptions("EntryBookTest2")))
            {
                var entryBook = FakeObjects.FakeObjects.GetEntryBook();
                context.EntryBook.Add(entryBook);
                context.SaveChanges();

                var sut = new EntryBookRepo(context);
                List<EntryBookDto> result = await sut.GetDataBySearchText(1, "x");
                Assert.NotNull(result);
                result[0].PersonName.Should().Equals("XYZ");
            }
        }

        private DbContextOptions<PhoneBookDBContext> GetOptions(string dbName) =>
            new DbContextOptionsBuilder<PhoneBookDBContext>().UseInMemoryDatabase(dbName).Options;
    }
}
