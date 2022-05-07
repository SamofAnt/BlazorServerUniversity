using BlazorServerUniversity;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using BlazorServerUniversity.Areas.Identity;
using BlazorServerUniversity.Data;
using BlazorServerUniversity.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.
var defConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var universityConnectionString = builder.Configuration.GetConnectionString("UniversityConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(defConnectionString));
builder.Services.AddDbContext<UniversityContext>(options =>
    options.UseSqlite(universityConnectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services
    .AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
builder.Services.AddAuthentication()
    .AddCookie("Cookies")
    .AddFacebook(options =>
    {
        options.AppId = "2316662895109472";
        options.AppSecret = "e25c1b8d4145034ed426d7a05efe1481";
    })
    .AddGoogle(options =>
    {
        IConfigurationSection googleAuthNSection =
            config.GetSection("Authentication:Google");
        options.ClientId =
            "841390499980-83gnvrkvo8njql1amc5vcbfbs46b6h3v.apps.googleusercontent.com";
        options.ClientSecret = "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";
    })
    .AddMicrosoftAccount(options =>
    {
        options.ClientId = config["Authentication:Microsoft:ClientId"];
        options.ClientSecret = config["Authentication:Microsoft:ClientSecret"];
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapDefaultControllerRoute()
    .RequireAuthorization();
app.Run();