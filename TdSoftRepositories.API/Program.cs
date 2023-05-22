using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TdSoftRepositories.API.CrossCutitng.DependencyInjection;
using TdSoftRepositories.API.Data.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<CoreContext>(options =>
    options.UseNpgsql("Server=localhost;Database=TdSoftRepositoriesBd;Port=5432;User Id=postgres;Password=admin;Ssl Mode=Disable;"));

ConfigureService.Configure(builder.Services);
ConfigureRepositories.Configure(builder.Services, builder.Configuration);
ConfigureMappers.Configure(builder.Services);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "TdSoftRepositories.API",
        Description = "Descricao da nossa API",
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