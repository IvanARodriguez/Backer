
namespace Backer.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
  public AuthenticationResult Login(string email, string password) => new(
    Guid.NewGuid(),
    email,
    "firstName",
    "lastName",
    "token"
  );

  public AuthenticationResult Register
  (
    string email,
    string password,
    string firstName,
    string lastName
  ) => new
    (
      Guid.NewGuid(),
      email,
      firstName,
      password,
      "token"
    );
}
