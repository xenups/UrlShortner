using Microsoft.EntityFrameworkCore;
using UrlShortner.Core.ApplicationServices.Urls.Commands.Shorter;
using UrlShortner.Core.Contracts.Urls;
using UrlShortner.Infra.Data.Sql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UrlShortnerDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IShorterAppService,ShorterAppService> ();
builder.Services.AddTransient<IUrlRepository, UrlRepository> ();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
