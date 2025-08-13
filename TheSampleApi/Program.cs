using TheSampleApi.Endpoints;
using TheSampleApi.Startup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.AddDependencies();

var app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();

app.AddRootEndpoints();
app.AddCourseEndpoints();

app.Run();
