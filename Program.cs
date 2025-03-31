using Sashiel_ST10028058_PROG7311_ICETask2.Services;
using Sashiel_ST10028058_PROG7311_ICETask2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ✅ Register IOrderService with its implementation
builder.Services.AddScoped<IOrderService, OrderService>();

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

app.UseAuthorization();

// ✅ Set default route to OrderController.Create
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Order}/{action=Create}/{id?}");

app.Run();
