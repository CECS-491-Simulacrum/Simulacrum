// From: https://supabase.com/blog/getting-started-with-the-supabase-dotnet-sdk
using Supabase.Core.Http;
using Supabase.Extensions.DependencyInjection;

// Loading variables from .env
DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// From: https://supabase.com/blog/getting-started-with-the-supabase-dotnet-sdk
// Connect to the DB on initialization, as per this guide
builder.Services.AddSupabase(
    supabaseUrl: builder.Configuration["SUPABASE_URL"]!,
    supabaseKey: builder.Configuration["SUPABASE_KEY"]!,
    configureOptions: options =>
    {
        options.AutoConnectRealtime = true;
        options.PostgrestRetry = new RetryOptions { MaxRetries = 3 };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
