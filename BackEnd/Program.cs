using Microsoft.EntityFrameworkCore;
using TipsOnPoints2.Configuration;
using TipsOnPoints2.Services;
using TipsOnPoints2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<OpenAIConfig>(builder.Configuration.GetSection("OpenAi"));
builder.Services.AddScoped<IOpenAiService, OpenAiService>();
builder.Services.AddScoped<ICardsService, CardsService>();
builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<ICardTipRepository, CardTipsRepository>();
builder.Services.AddScoped<IThemeRepository, ThemeRepository>();
builder.Services.AddScoped<IThemeService, ThemeService>();
builder.Services.AddControllers();
//builder.Services.AddDbContextFactory
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Aplica as migrações ao banco de dados
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.Run();
