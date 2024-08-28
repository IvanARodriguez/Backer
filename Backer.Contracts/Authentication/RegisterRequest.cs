namespace Backer.Contracts.Authentication;

public record RegisterRequest(string FirstName, String LastName, string Email, string Password);