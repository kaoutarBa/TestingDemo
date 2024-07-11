namespace TestingDemo;

public record User()
{
    public string FirstName = string.Empty;
    public string LastName = string.Empty;
    public int Id { get; init; } = 0;
    public DateTime CreatedDate { get; init; } = DateTime.UtcNow;
    public string Phone { get; set; } = "+33 ";
    public bool VerifiedEmail { get; set; } = false;
}

public record UserDTO()
{
    public string FirstName = string.Empty;
    public string LastName = string.Empty;
    public string Phone { get; set; } = "+33 ";
    public bool VerifiedEmail { get; set; } = false;
}