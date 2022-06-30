using ExpensiveControlApp.Infra.DataBase;
using ExpensiveControlApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ExpensiveControlContext>();
// Feita a injeção de dependencia

builder.Services.AddScoped<IExpensiveService, ExpensiveService>();
// Injeção de dependencia do "IExpensiveService"


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Expensive}/{action=Index}/{id?}");

app.Run();
