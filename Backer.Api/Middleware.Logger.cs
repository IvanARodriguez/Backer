using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backer.Api.Middleware;
public class Logger(RequestDelegate next, ILogger<Logger> _logger)
{
  public async Task InvokeAsync(HttpContext context)
  {
    // Log the incoming request
    _logger.LogInformation("Incoming Request: {method} {url}", context.Request.Method, context.Request.Path);

    // Read and log the request body if needed
    context.Request.EnableBuffering();
    var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
    context.Request.Body.Position = 0; // Reset the stream position after reading
    _logger.LogInformation("Request Body: {body}", requestBody);

    // Copy the original response body stream
    var originalBodyStream = context.Response.Body;

    using var responseBody = new MemoryStream();
    context.Response.Body = responseBody;

    // Continue the middleware pipeline
    await next(context);

    // Log the outgoing response
    context.Response.Body.Seek(0, SeekOrigin.Begin);
    var responseText = await new StreamReader(context.Response.Body).ReadToEndAsync();
    context.Response.Body.Seek(0, SeekOrigin.Begin);

    _logger.LogInformation("Outgoing Response: {statusCode}", context.Response.StatusCode);
    _logger.LogInformation("Response Body: {responseText}", responseText);

    // Copy the response body back to the original stream
    await responseBody.CopyToAsync(originalBodyStream);
  }

}