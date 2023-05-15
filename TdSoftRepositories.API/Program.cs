using Microsoft.OpenApi.Models;
using TdSoftRepositories.API.CrossCutitng.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

ConfigureService.Configure(builder.Services);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "TdSoftRepositories.API",
        Description = "Descrição da nossa API",
        Version = "v1",
        Contact = new OpenApiContact
        {
            Name = "Eduardo Godoy & Ricardo Egídio",
            Email = null,
            Url = null
        }
    });

    var xmlFile = "TdSoftRepositories.API.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();