namespace TestingDemo.Implementations;


public class UserManagement : IUserManagement
{
    private readonly List<User> _users = new List<User>();

    private int _idCounter = 1;

    public IEnumerable<User> GetAllUsers()
    {
        return _users;
    }

    public void AddUser(UserDTO newUserDto)
    {
        User newUser = new()
        {
            Id = _idCounter++,
            FirstName = newUserDto.FirstName,
            LastName = newUserDto.LastName,
            VerifiedEmail = newUserDto.VerifiedEmail,
            Phone = newUserDto.Phone,
        };
        _users.Add(newUser);
    }
    public void UpdatePhone(int userId, string newPhone)
    {
        var userToUpdate = _users.FirstOrDefault(u => u.Id == userId);

        if (userToUpdate != null)
        {
            userToUpdate.Phone = newPhone;
        }
        else
        {
            Console.WriteLine($"Utilisateur avec l'ID {userId} non trouvé.");
        }
    }

    public void VerifyEmail(int userId)
    {
        var userToVerify = _users.FirstOrDefault(u => u.Id == userId);

        if (userToVerify != null)
        {
            userToVerify.VerifiedEmail = true;
        }
        else
        {
            Console.WriteLine($"Utilisateur avec l'ID {userId} non trouvé.");
        }
    }
}