using Moq;
using CodingKata.Repository.Abstractions;
using Xunit;
using Codingkata.Models;
using System.Threading.Tasks;

namespace CodingKata.Repository.Tests
{
    public class UserManagerTest
    {
        private readonly Mock<IUserRepository> userRepo;
        public UserManagerTest()
        {
            userRepo = new Mock<IUserRepository>();
        }

        //[Fact]
        //public async Task Add_RegistrationSuccessful_Returns_True()
        //{
        //    var actual = await userRepo
        //                        .Setup(x => x.RegisterVaccination(It.IsAny<VaccineRegister>()))
        //                        .ReturnsAsync(true);
        //    Assert.True(true);
        //}
    }
}