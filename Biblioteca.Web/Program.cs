using Biblioteca.Data.Model;
using Biblioteca.Data.Interfaces;
using Biblioteca.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

//Injeção de Dependência
builder.Services.AddDbContext<DBLivrariaContext>(options => options.UseSqlServer(config.GetConnectionString("DBLivrariaConnection")));

builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped<IGeneroRespositoryAsync, GeneroRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
