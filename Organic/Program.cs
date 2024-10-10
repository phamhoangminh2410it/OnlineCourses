using Microsoft.EntityFrameworkCore;
using Organic.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<OrganicContext>(p =>
    p.UseSqlServer(builder.Configuration.GetConnectionString("Organic")));
builder.Services.AddMvc();

var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();