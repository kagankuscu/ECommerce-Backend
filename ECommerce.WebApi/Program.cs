using ECommerce.DataAccess;
using Microsoft.EntityFrameworkCore;
using ECommerce.Business.Configuration;

var builder = WebApplication.CreateBuilder(args);

string policyName = "ECommerceFrontend";
builder.Services.AddCors(opt =>
{
    opt.AddPolicy(policyName, policy =>
    {
        policy.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddRepository();
builder.Services.AddBusiness();
builder.Services.AddAutoMapper();
builder.Services.AddDataShaper();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<ApplicationDbContext>().Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(policyName);
app.UseAuthorization();

app.MapControllers();

app.Run();
