using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using MBS.Persistence.Database;
using System.Reflection;
using MBS.Infrastructure.AuthSetting;
using MBS.Persistence.DIModule.RegisterDIModule;
using MBS.Application.DIModule.RegisterDIModule;
var builder = WebApplication.CreateBuilder(args);


#region DbConnectionSetting

string connectionString = builder.Configuration.GetConnectionString("connString")??
                   throw new InvalidOperationException("Connection String not Found");//Server=.\SQLEXPRESS;Database=MBS;Encrypt=False;Trusted_Connection=True; TrustServerCertificate=true;
var migrationString = typeof(ApplicationDatabase).Assembly.FullName; //MBS.Persistence, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
#endregion



#region AutoFacSetting
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.ApplicationModules();
    containerBuilder.PersistenceModules(connectionString, migrationString);
    containerBuilder.Infrastructure();

});
#endregion

#region AuthenticationSetting
var Key = builder.Configuration["Jwt:Key"];
var Issuer = builder.Configuration["Jwt:Issuer"];
var Audience = builder.Configuration["Jwt:Audience"];
builder.Services.IdentityConfig();
builder.Services.JwtTokenConfig(Key,Issuer,Audience);





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
