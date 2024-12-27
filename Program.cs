using CRMSardis.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

<<<<<<< HEAD
// Add DbContext to services
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

=======
// Add DbContext to services (EF Core Veritabanı Bağlantısı)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add session services
builder.Services.AddDistributedMemoryCache(); // Oturum için gerekli
builder.Services.AddSession(); // Oturum için gerekli

>>>>>>> 710e3ed (Proje dosyalarını ekledim)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
<<<<<<< HEAD
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
=======

app.UseSession(); // Oturum yönetimini etkinleştir
app.UseAuthorization();

// Başlangıç rotası Login olarak ayarlandı
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");
>>>>>>> 710e3ed (Proje dosyalarını ekledim)

app.Run();
