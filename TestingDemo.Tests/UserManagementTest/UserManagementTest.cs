namespace TestingDemo.Tests.UserManagementTest;

public class UserManagementTest
{
    [Fact]
    public void Add_CreateUser()
    {
        // Arrange
        var userManagement = new UserManagement();

        // Act
        userManagement.AddUser(
            new UserDTO()
            {
                FirstName = "ANA",
                LastName = "AYA",
                Phone = "+33000001"
            }
            );

        // Assert
        var savedUser = Assert.Single(userManagement.GetAllUsers());
        Assert.NotNull(savedUser);
        Assert.Equal("ANA", savedUser.FirstName);
        Assert.Equal("AYA", savedUser.LastName);
        Assert.Equal("+33000001", savedUser.Phone);
        Assert.NotEmpty(savedUser.Phone);
        Assert.False(savedUser.VerifiedEmail);
    }

    [Fact]
    public void Verify_VerifyEmailAddress()
    {
        // Arrange
        var userManagement = new UserManagement();

        // Act
        userManagement.AddUser(
            new UserDTO()
            {
                FirstName = "ANA",
                LastName = "ANA",
                Phone = "+33000001"
            }
            );

        var firstUser = userManagement.GetAllUsers().ToList().First();
        userManagement.VerifyEmail(firstUser.Id);

        // Assert
        var savedUser = Assert.Single(userManagement.GetAllUsers());
        Assert.True(savedUser.VerifiedEmail);

        //Assert.False(savedUser.VerifiedEmail);
    }

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
        Assert.Equal("+33000004", savedUser.Phone);
    }
}