namespace TestingDemo.Implementations
{
    public class UserManagement : IUserManagement
    {
        private readonly IUserRepository _userRepository;
        private readonly List<User> _users = new List<User>();
        private int _idCounter = 1;

        public UserManagement(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
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
            _userRepository.AddUser(newUserDto); // Using the repository to add user
        }

        public void UpdatePhone(int userId, string newPhone)
        {
            _userRepository.UpdatePhone(userId, newPhone); // Using the repository to update phone
        }

        public void VerifyEmail(int userId)
        {
            _userRepository.VerifyEmail(userId); // Using the repository to verify email
        }
    }
}
