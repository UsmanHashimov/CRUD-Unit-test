using Crud_Unit_Test.Models;
using Moq;

namespace CRUD.Tests.Unit
{
    public partial class UserServiceTests
    {
        [Fact]
        public async Task ShouldAddNewUserAsync()
        {
            //Arrange
            var inputUser = new User()
            {
                Id = 1,
                Name = "Joe",
                Email = "joe@gmail.com",
                Password = "123456"
            };

            var expectedUser = new User()
            {
                Id = inputUser.Id,
                Name = inputUser.Name,
                Email = inputUser.Email,
                Password = inputUser.Password,
            };

            _mockUserRepository.Setup(x
                => x.AddAsync(It.IsAny<User>()))
                .ReturnsAsync(expectedUser);

            //Act
            var actualUser = await _userService.AddAsync(inputUser);

            //Assert
            Assert.Equal(expectedUser, actualUser);
        }

        [Fact]
        public async Task ShouldDeleteUserAsync()
        {
            //Arrange
            var inputUser = new User()
            {
                Id = 1,
                Name = "Joe",
                Email = "joe@gmail.com",
                Password = "123456"
            };

            var expectedUser = new User()
            {
                Id = inputUser.Id,
                Name = inputUser.Name,
                Email = inputUser.Email,
                Password = inputUser.Password,
            };

            _mockUserRepository.Setup(x => x.DeleteAsync(It.IsAny<User>()))
                .ReturnsAsync(expectedUser);

            //Act
            var actualUser = await _userService.DeleteAsync(inputUser.Id);

            //Assert
            Assert.Equal(expectedUser.Name, actualUser.Name);
            Assert.Equal(expectedUser.Email, actualUser.Email);
            Assert.Equal(expectedUser.Password, actualUser.Password);
        }

        [Fact]
        public async Task ShouldUpdateUserAsync()
        {
            //Arrange
            var inputUser = new User()
            {
                Id = 1,
                Name = "Joe",
                Email = "joe@gmail.com",
                Password = "123456"
            };

            var expectedUser = new User()
            {
                Id = inputUser.Id,
                Name = inputUser.Name,
                Email = inputUser.Email,
                Password = inputUser.Password,
            };

            _mockUserRepository.Setup(x => x.UpdateAsync(It.IsAny<User>()))
                .ReturnsAsync(expectedUser);

            //Act
            var actualUser = await _userService.UpdateAsync(inputUser, inputUser.Id);

            //Assert
            Assert.Equal(expectedUser.Name, actualUser.Name);
            Assert.Equal(expectedUser.Email, actualUser.Email);
            Assert.Equal(expectedUser.Password, actualUser.Password);
        }

        [Fact]
        public async Task ShouldGetUserByIdAsync()
        {
            // Arrange
            var userId = 1;
            var expectedUser = new User()
            {
                Id = userId,
                Name = "Joe",
                Email = "joe@gmail.com",
                Password = "123456"
            };

            _mockUserRepository.Setup(x => x.GetAsync(userId))
                .ReturnsAsync(expectedUser);

            // Act
            var actualUser = await _userService.GetAsync(userId);

            // Assert
            Assert.NotNull(actualUser);
            Assert.Equal(expectedUser.Id, actualUser.Id);
            Assert.Equal(expectedUser.Name, actualUser.Name);
            Assert.Equal(expectedUser.Email, actualUser.Email);
            Assert.Equal(expectedUser.Password, actualUser.Password);
        }

        [Fact]
        public async Task ShouldGetAllUsersAsync()
        {
            // Arrange
            var expectedUsers = new List<User>
            {
                new User() { Id = 1, Name = "Joe", Email = "joe@gmail.com", Password = "123456" },
                new User() { Id = 2, Name = "Jane", Email = "jane@gmail.com", Password = "654321" }
            };

            _mockUserRepository.Setup(x => x.GetAllAsync())
                .ReturnsAsync(expectedUsers);

            // Act
            var actualUsers = await _userService.GetAllAsync();

            // Assert
            Assert.NotNull(actualUsers);
            Assert.Equal(expectedUsers.Count, actualUsers.Count());
            Assert.Equal(expectedUsers[0].Id, actualUsers.ToList()[0].Id);
            Assert.Equal(expectedUsers[1].Id, actualUsers.ToList()[1].Id);
        }
    }
}
