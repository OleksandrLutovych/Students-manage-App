using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project_zarzadzanie_studentami.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Project_zarzadzanie_studentamiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Project_zarzadzanie_studentamiContext") ?? throw new InvalidOperationException("Connection string 'Project_zarzadzanie_studentamiContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
