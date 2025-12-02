using Microsoft.EntityFrameworkCore;
using Library.Context;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Configure EF Core to use SQL Server
    // We load the connection string from appsettings.json:
    //
    //  "ConnectionStrings": {
    //      "SqlString": "Server=RICCARDO\\SQLEXPRESS;Database=OUTDOORWAYS;Trusted_Connection=True;"
    //  }
    //
    // builder.Configuration.GetConnectionString("SqlString")
    // extracts exactly that text.
    //
    // This is the string EF uses to connect to SQL Server.
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlString"));
});

// ADD SERVICE TO STORE DATA FOR THE SINGLE SESSION
builder.Services.AddSession();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
