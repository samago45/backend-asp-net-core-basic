using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using web_backend.Security;

using webClientsApi.DataAccess;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//2 Conection with SQL 
const string CONNECTIONNAME = "BackendDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


//3 Add Context
builder.Services.AddDbContext<BacKendDBContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

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

app.UseAuthentication();

app.UseAuthorization();

app.UseAuthorization();

    app.MapControllers();

    app.Run();
