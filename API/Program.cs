using Implementations;
using Interfaces;
using KRModels.Context;
using Microsoft.EntityFrameworkCore;
using Operations;
using SkinAbstraction;

var builder = WebApplication.CreateBuilder(args);

AddDbContextObject(builder);

void AddDbContextObject(WebApplicationBuilder builder)
{
    string connectionstring = builder.Configuration.GetConnectionString("KRConnectionstring");

    builder.Services.AddDbContextFactory<KRContext>(options => options.UseSqlServer(connectionstring), ServiceLifetime.Scoped);
}

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<SkinAbstraction.ISkinAbstraction, SkinAbstraction.SkinAbstraction>();
builder.Services.AddTransient<ISkinOperations, SkinOperations>();
builder.Services.AddTransient<IMSkinDML, MSkinDML>();
builder.Services.AddTransient<ILevelAbstraction, LevelAbstraction>();
builder.Services.AddTransient<ILevelOperations, LevelOperations>();
builder.Services.AddTransient<IMLevelDML, MLevelDML>();
builder.Services.AddTransient<IModuleAbstraction, ModuleAbstraction>();
builder.Services.AddTransient<IModuleOperations, ModuleOperations>();
builder.Services.AddTransient<IModuleDML, MModuleDML>();


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
