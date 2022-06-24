using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DevOpsTask.DAL.Abstract;
using DevOpsTask.DAL.Concrete;
using DevOpsTask.Models;
using DevOpsTask.Areas.Identity.Data;
using DevOpsTask.Utilities;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DevOpsTaskIdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'DevOpsTaskIdentityDbContextConnection' not found.");

builder.Services.AddDbContext<DevOpsTaskIdentityDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Configuration.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<DevOpsTaskIdentityDbContext>();

var dbConnectionString = builder.Configuration.GetConnectionString("DbConnection");

//db stuff
builder.Services.AddDbContext<BandcDbContext>(options => options.UseSqlServer(dbConnectionString));
//builder.Services.AddDbContext<IdentityContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<DbContext, DevOpsTaskIdentityDbContext>();
builder.Services.AddScoped<DbContext, BandcDbContext>();
builder.Services.AddScoped<IPersonApplicationRepository, PersonApplicationRepository>();
builder.Services.AddScoped<IMBoardsandCommissionRepository, MBoardsandCommissionRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<ISubmittedApplicationRepository, SubmittedApplicationRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "/api/Fun/Home",
    defaults: new { controller = "Home", actions = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        // Get the IConfiguration service that allows us to query user-secrets and 
        // the configuration on Azure
        var config = app.Services.GetRequiredService<IConfiguration>();
        // Set password with the Secret Manager tool, or store in Azure app configuration
        // dotnet user-secrets set SeedUserPW <pw>

        var adminPw = config["SeedAdminPW"];

        SeedUsers.InitializeAdmin(services, "admin@example.com", "Admin", adminPw, "The", "Admin").Wait();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}


app.Run();
