namespace Api.Middlewares;

// You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        this._logger = logger;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);

        }
        catch (Exception ex)
        {
            if (ex.InnerException != null)
            {
                _logger.LogError("{ExceptionType}{ExceptionMessage}", ex.InnerException.GetType(), ex.InnerException.Message);
            }
            else
            {

                _logger.LogError("{ExceptionType}{ExceptionMessage}", ex.GetType().ToString(), ex.Message);
            }
            _logger.LogInformation("\n========Exception Handling in process.================\n");
            _logger.LogError(ex, "An unhandled exception has occurred while processing the request.");

            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await httpContext.Response.WriteAsJsonAsync(new {Type=ex.GetType().ToString(),Message=ex.Message.ToString()});


            _logger.LogInformation("========End Of Exception Handling in process.================");

        }


    }
}

// Extension method used to add the middleware to the HTTP request pipeline.
public static class ExceptionHandlingMiddlewareExtensions
{
    public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionHandlingMiddleware>();
    }
}
