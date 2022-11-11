using Requiem.PollingSystem.Web.Definitions.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDefinitions(builder, typeof(Program));

var app = builder.Build();

app.UseDefinitions();

