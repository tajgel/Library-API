using Library.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

LibraryEndpoints.MapLibraryEndpoints(app);

app.Run();