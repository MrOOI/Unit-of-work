using TESTUoW.Repository.DbContext;
using TESTUoW.Repository.Implementations;
using TESTUoW.Repository.Interfaces;
using TESTUoW.Service.Interfaces;
using TESTUoW.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetSection("DbSettings");
builder.Services.Configure<DatabaseSettings>(opt =>
{
    opt.Database = connection.GetValue("Database", "");
    opt.Server = connection.GetValue("Server", "");
    opt.UserId = connection.GetValue("UserId", "");
    opt.Password = connection.GetValue("Password", "");
});
builder.Services.AddSingleton<DatabaseContext>()
    .AddScoped<IPersonRepository, PersonRepository>()
    .AddScoped<IUoW, UoW>()
    .AddScoped<IPersonService, PersonService>()
    .AddScoped<IServices, Services>();

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
