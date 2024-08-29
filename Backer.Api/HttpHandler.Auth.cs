using Backer.Application.Services.Authentication;
using Backer.Contracts.Authentication;

namespace Backer.Api.Handlers;

public static class HttpHandlerAuth
{
    public static void MapAuthEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/auth/register", (RegisterRequest req, IAuthenticationService authenticationService) =>
        {
            var authResult = authenticationService.Register(
                req.Email,
                req.Password,
                req.FirstName,
                req.LastName);
            var response = new AuthenticationResponse(
                authResult.Id,
                authResult.Email,
                authResult.FirstName,
                authResult.LastName,
                authResult.Token
            );
            return Results.Ok(response);
        });

        endpoints.MapPost("/auth/login", (LoginRequest req, IAuthenticationService authenticationService) =>
        {
            var authResult = authenticationService.Login(
                req.Email,
                req.Password);

            var response = new AuthenticationResponse(
                authResult.Id,
                authResult.Email,
                authResult.FirstName,
                authResult.LastName,
                authResult.Token
            );
            return Results.Ok(response);
        });
    }
}

