var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controladores (necessário para funcionar com o RelatoriosController)
builder.Services.AddControllers();

var app = builder.Build();

// Configura o uso de HTTPS redirecionado (opcional, mas recomendado)
app.UseHttpsRedirection();

// Configura o roteamento para os controladores
app.MapControllers();

// Inicia o aplicativo
app.Run();
