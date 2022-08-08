var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    WebRootPath = "doesnotexist"
});
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
