using PetShop.Data;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;
using PetShop.src.Repository;
using PetShop.src.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<PetShop.src.Contrato.Repository.IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IServicoRepository, ServicoRepository>();
builder.Services.AddScoped<PetShop.src.Contrato.Service.IClienteService, ClienteService>();
builder.Services.AddScoped<IAnimaisService, AnimalService>();
builder.Services.AddScoped<IServicoService, ServicoService>();
builder.Services.AddSingleton<DapperContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
