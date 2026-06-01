using BrainX.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionando o SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=brainx_v2.db"));

// Adiciona suporte aos Controllers
builder.Services.AddControllers(); 

// Configuração do Swagger UI (Substituindo o antigo AddOpenApi)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura o CORS para o React na porta 3000 ou 5173 (Vite geralmente usa 5173, ajustei para suportar ambos)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact", policy =>
    {
        policy.WithOrigins("http://localhost:3000", "http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowReact");

if (app.Environment.IsDevelopment())
{
    // Ativa a interface gráfica do Swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();