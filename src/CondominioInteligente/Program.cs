using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CondominioInteligente.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CondominioInteligenteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CondominioInteligenteContext") ?? throw new InvalidOperationException("Connection string 'CondominioInteligenteContext' not found.")));


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.LoginPath = "/Usuarios/Login";
    options.AccessDeniedPath = "/Usuarios/AccessDenied";
    options.LogoutPath = "/Usuarios/Logout";
    options.SlidingExpiration = true;
});


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

app.Use(async (context, next) =>
{
    string EnteredPath = context.Request.HttpContext.Request.Path.ToString().Remove(0, 1);
    await next();

    if (context.Response.StatusCode == 404)
    {
        context.Request.Path = "/Usuarios/Login";
        await next();
    }
});

app.UseRouting();

app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
