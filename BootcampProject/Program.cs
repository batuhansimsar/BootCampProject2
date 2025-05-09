using BootcampProject.Business.Interfaces;
using BootcampProject.Business.Managers;
using BootcampProject.Repositories.Context;
using BootcampProject.Repositories.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BootcampDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IApplicationService, ApplicationManager>();
builder.Services.AddScoped<IApplicationRepository, EfApplicationRepository>();
builder.Services.AddScoped<IBootcampService, BootcampManager>();
builder.Services.AddScoped<IBootcampRepository, EfBootcampRepository>();
builder.Services.AddScoped<IBlacklistService, BlacklistManager>();
builder.Services.AddScoped<IBlacklistRepository, EfBlacklistRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();

