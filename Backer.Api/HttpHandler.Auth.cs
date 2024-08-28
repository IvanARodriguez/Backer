
using Backer.Contracts.Authentication;

namespace Backer.Api.Handlers;

public static class HttpHandlerAuth
{
    public static void MapAuthEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/auth/register", (RegisterRequest req) =>
        {
            return Results.Ok(req);
        });

        app.MapPost("/auth/login", (LoginRequest request) =>
        {
            // Simulate login logic
            return Results.Ok(request);
        });
    }
}
