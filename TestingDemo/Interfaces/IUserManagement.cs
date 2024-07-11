namespace TestingDemo.Interfaces;
public interface IUserManagement
{
    public IEnumerable<User> GetAllUsers();
    public void AddUser(UserDTO userDto);
    public void UpdatePhone(int userId, string newPhone);
    public void VerifyEmail(int userId);
}

