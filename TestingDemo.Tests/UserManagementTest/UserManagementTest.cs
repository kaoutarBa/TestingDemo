namespace TestingDemo.Tests
{
    public class UserManagementTests
    {
        [Fact]
        public void GetAllUsers_ReturnsAllUsers()
        {
            // Arrange
            var mockRepository = new Mock<IUserRepository>();
            var expectedUsers = new List<User>
            {
<<<<<<< Updated upstream
                new User { Id = 1, FirstName = "ANA", LastName = "AYA", VerifiedEmail = true, Phone = "1234567890" },
                new User { Id = 2, FirstName = "MAX", LastName = "IN", VerifiedEmail = false, Phone = "9876543210" }
            };
=======
                FirstName = "ANA",
                LastName = "AYAA",
                Phone = "+33000001"
            }
            );
>>>>>>> Stashed changes

            mockRepository.Setup(repo => repo.GetAllUsers()).Returns(expectedUsers);

            var userManagement = new UserManagement(mockRepository.Object);

            // Act
            var result = userManagement.GetAllUsers();

            // Assert
            Assert.Equal(expectedUsers, result);
        }

        [Fact]
        public void AddUser_NewUser_AddsToRepository()
        {
            // Arrange
            var mockRepository = new Mock<IUserRepository>();
            var userManagement = new UserManagement(mockRepository.Object);

            var newUserDto = new UserDTO
            {
                FirstName = "Alice",
                LastName = "Wonderland",
                VerifiedEmail = false,
                Phone = "5555555555"
            };

            // Act
            userManagement.AddUser(newUserDto);

            // Assert
            mockRepository.Verify(repo => repo.AddUser(It.IsAny<UserDTO>()), Times.Once);
        }

        [Fact]
        public void UpdatePhone_ExistingUser_UpdatesPhone()
        {
            // Arrange
            int userId = 1;
            string newPhone = "9999999999";
            var mockRepository = new Mock<IUserRepository>();
            var userManagement = new UserManagement(mockRepository.Object);

            // Act
            userManagement.UpdatePhone(userId, newPhone);

            // Assert
            mockRepository.Verify(repo => repo.UpdatePhone(userId, newPhone), Times.Once);
        }

        [Fact]
        public void VerifyEmail_ExistingUser_VerifiesEmail()
        {
            // Arrange
            int userId = 1;
            var mockRepository = new Mock<IUserRepository>();
            var userManagement = new UserManagement(mockRepository.Object);

            // Act
            userManagement.VerifyEmail(userId);

            // Assert
            mockRepository.Verify(repo => repo.VerifyEmail(userId), Times.Once);
        }
    }
<<<<<<< Updated upstream
}
=======

    [Fact]
    public void Update_UpdateMobileNumber()
    {
        // Arrange
        var userManagement = new UserManagement();

        // Act
        userManagement.AddUser(
            new UserDTO()
            {
                FirstName = "ANA",
                LastName = "ANA",
                Phone = "+33000003"
            }
            );

        var firstUser = userManagement.GetAllUsers().ToList().First();
        userManagement.UpdatePhone(firstUser.Id, "+33000004");

        // Assert
        var savedUser = Assert.Single(userManagement.GetAllUsers());
        Assert.Equal("+33000005", savedUser.Phone);
    }
}
>>>>>>> Stashed changes
