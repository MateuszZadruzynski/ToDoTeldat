using DBConnect;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Radzen;
using ToDoTeldat.Interfaces;
using ToDoTeldat.Services;

var builder = WebApplication.CreateBuilder(args);
var connnectionString = builder.Configuration.GetConnectionString("Default")
    ?? throw new NullReferenceException("No connection string!");

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContextFactory<DBConnects>((DbContextOptionsBuilder options) => 
    options.UseSqlServer(connnectionString));

builder.Services.AddScoped<IToDoTask,ToDoTaskService>();

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
