using Microsoft.FluentUI.AspNetCore.Components;
using HomeAssets.Components;
using HomeAssets.Components.Repositories;
using HomeAssets.Data;
using HomeAssets.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ILocationService,LocationService>();
builder.Services.AddScoped<IItemService,ItemService>();
builder.Services.AddScoped<ILabelService,LabelService>();
builder.Services.AddScoped<IItemLabelService,ItemLabelService>();
builder.Services.AddScoped<IHomeService,HomeService>();

builder.Services.AddFluentUIComponents();

builder.Services.AddDbContext<AppDbContext>(options=>
    
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
    );


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
