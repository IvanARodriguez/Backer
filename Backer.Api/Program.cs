var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapGet("/test", () => { return new { message = "API working as expected" }; });
    app.Run();
}

