using CrimeRecordsSystem.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. MUST BE HERE: Register the Database Context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"), 
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    ));

// Add Session and Controllers
builder.Services.AddSession();
builder.Services.AddControllersWithViews();

// 2. MUST BE AFTER THE SERVICES ARE ADDED
var app = builder.Build(); 

// ... rest of the code (app.UseSession, app.UseRouting, etc.)
app.UseSession(); // Enable session middleware
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();