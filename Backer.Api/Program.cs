using Backer.Api.Handlers;
using Backer.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddEndpointsApiExplorer();
  builder.Services.AddHttpLogging(logger =>
  {
    logger.MediaTypeOptions.AddText("application/javascript");
    logger.CombineLogs = true;
  });
  builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
  app.UseHttpsRedirection();
  app.UseHttpLogging();
  app.UseMiddleware<Logger>();
  app.MapGet("/test", () => { return new { message = "API working as expected" }; });
  app.MapAuthEndpoints();
  app.Run();
}

