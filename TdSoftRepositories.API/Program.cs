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
    // Definir endpoint swagger para arquivo em swagger/swagger-doc.yaml para que a documentação de swagger possa ser acessada em https://localhost:<port>/swagger/swagger-doc.yaml (https://localhost:<port>/swagger/swagger-doc.yaml)
    app.UseSwagger();
    // Definir endpoint swagger para arquivo em swagger/swagger-doc.yaml para que a documentação de swagger possa ser acessada em https://localhost:<port>/swagger/swagger-doc.yaml (https://localhost:<port>/swagger/swagger-doc.yaml)
    app.UseSwaggerUI();
}

// Definir swagger-doc como endpoint de swagger para que se pueda acceder a la documentación de swagger desde la raíz del sitio web (https://localhost:<puerto>/)


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
