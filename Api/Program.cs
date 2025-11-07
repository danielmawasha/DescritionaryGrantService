using BusinessLogicLayer;
using DataAccessLayer;
using Api.Middlewares;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// BLL & DAL dependency injections
builder.Services.AddBusinessLogicLayer();
builder.Services.AddDataAccessLayer();

// API endpoints explorer
builder.Services.AddEndpointsApiExplorer();

// Add services to the container.
builder.Services.AddSwaggerGen((options) =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Descritionary Grant Service API", Version = "v1" });

});

builder.Services.AddControllers();


var app = builder.Build();

//cors
app.UseCors();

//routing
app.UseRouting();

//swagger configuration
app.UseSwagger();
app.UseSwaggerUI();


//custom exception handling middleware
app.UseMiddleware<ExceptionHandlingMiddleware>();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
