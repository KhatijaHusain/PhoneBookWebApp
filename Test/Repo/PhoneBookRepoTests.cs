using CibDigiTechWebApp.DbContexts;
using CibDigiTechWebApp.Repository;
using CibDigiTechWebApp.Service;
using NSubstitute;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace Test.Repo
{
    public class PhoneBookRepoTests
    {
        private readonly IPhoneBookRepo _phoneBookRepo = Substitute.For<IPhoneBookRepo>();
        private readonly IPhoneBookService _phoneBookService = Substitute.For<IPhoneBookService>();

        [Fact]
        public async Task GetById_WhenValidId_ReturnPhoneBook()
        {
            using (var context = new PhoneBookDBContext(GetOptions("PhoneBookTest1")))
            {
                var phoneBook = FakeObjects.FakeObjects.GetPhoneBook();
                context.PhoneBookDto.Add(phoneBook);
                context.SaveChanges();

                var sut = new PhoneBookRepo(context);
                var result = await sut.GetDataById(phoneBook.PhoneBookId);
                Assert.NotNull(result);
                result.PhoneBookName.Should().Equals("Home");
            }
        }

        private DbContextOptions<PhoneBookDBContext> GetOptions(string dbName) =>
            new DbContextOptionsBuilder<PhoneBookDBContext>().UseInMemoryDatabase(dbName).Options;

    }
}
