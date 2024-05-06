using MBS.Persistence.Database;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


#region DbConnectionSetting

string conString = builder.Configuration.GetConnectionString("connString")??
                   throw new InvalidOperationException("Connection String not Found");
string migrationString = typeof(ApplicationDatabase).Assembly.FullName;
#endregion







// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
