var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Definir endpoint swagger para arquivo em swagger/swagger-doc.yaml para que a documenta��o de swagger possa ser acessada em https://localhost:<port>/swagger/swagger-doc.yaml (https://localhost:<port>/swagger/swagger-doc.yaml)
    app.UseSwagger();
    // Definir endpoint swagger para arquivo em swagger/swagger-doc.yaml para que a documenta��o de swagger possa ser acessada em https://localhost:<port>/swagger/swagger-doc.yaml (https://localhost:<port>/swagger/swagger-doc.yaml)
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();