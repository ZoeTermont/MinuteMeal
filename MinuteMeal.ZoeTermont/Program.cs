using Microsoft.EntityFrameworkCore;
using MinuteMeal.ZoeTermont.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<MinuteMealData>(options =>
    options.UseInMemoryDatabase("MinuteMealsDb"));
builder.Services.AddControllersWithViews();

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


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<MinuteMealData>();
    context.Seed();
}

app.Run();