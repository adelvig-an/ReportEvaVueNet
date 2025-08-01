using BussinesLayer.Interfaces;
using BussinesLayer.Repository;
using DbLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

//��� �������
string dadataToken = builder.Configuration["Dadata:Token"];
string dadataSecret = builder.Configuration["Dadata:Secret"];

// Add services to the container.

// ������������ PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));

    // ������ ��� ����������!
    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging()
               .LogTo(Console.WriteLine,
                     new[] { DbLoggerCategory.Database.Command.Name },
                     LogLevel.Information,
                     DbContextLoggerOptions.SingleLine);
    }
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
    options.AddPolicy("AllowFrontend", policy =>
        policy.WithOrigins("http://localhost:5173") // ���� Vite
            .AllowAnyMethod()
            .AllowAnyHeader()));

builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContractRepository, ContractRepository>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.EnsureDeleted(); // ������� ��, ���� ��� ���� (�� ��� ��������!)
    dbContext.Database.EnsureCreated(); // ������� ��, ���� � ��� (�� ��� ��������!)
    // ���: dbContext.Database.Migrate(); � ��������� ��������
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontend");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
