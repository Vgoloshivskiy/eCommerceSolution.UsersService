using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;
using System.Text.Json.Serialization;
using eCommerce.Core.Mappers;
using AutoMapper;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Add Infrastructure services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

//Add Controllers 
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
builder.Services.AddAutoMapper(cfg =>
{
    cfg.LicenseKey = "YOUR_LICENSE_KEY";
},   typeof(ApplicationUserMappingProfile).Assembly);
builder.Services.AddFluentValidationAutoValidation();
var app = builder.Build();
app.UseExceptionHandlerMiddleware();
//Add Routing
app.UseRouting();
//Add Authentication and Authorization
app.UseAuthorization();
app.UseAuthentication();

//Add Endpoints
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
