namespace TestingDemo.Interfaces;

public interface IUserRepository
{
    IEnumerable<User> GetAllUsers();
    void AddUser(UserDTO newUserDto);
    void UpdatePhone(int userId, string newPhone);
    void VerifyEmail(int userId);
}
