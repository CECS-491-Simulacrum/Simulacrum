/** References:
 *
 * ASP.NET Core startup process:
 * https://learn.microsoft.com/en-us/aspnet/core/fundamentals/startup?view=aspnetcore-10.0
 *
 * Microsoft OpenAPI library & Swagger UI documentation:
 * https://learn.microsoft.com/en-us/aspnet/core/fundamentals/openapi/using-openapi-documents?view=aspnetcore-10.0
 *
 * Supabase client setup (DB connection upon initialization):
 * https://supabase.com/blog/getting-started-with-the-supabase-dotnet-sdk
 *
 * DbContext configuration and DI:
 * https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/
 */

using Simulacrum.Infrastructure;
using Supabase.Core.Http;
using Supabase.Extensions.DependencyInjection;

DotNetEnv.Env.Load(); // Loading variables from .env

// 1. Configure app settings & register services for dependency injection.
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSupabase(
    supabaseUrl: builder.Configuration["SUPABASE_URL"]!,
    supabaseKey: builder.Configuration["SUPABASE_KEY"]!,
    configureOptions: options =>
    {
        options.AutoConnectRealtime = true;
        options.PostgrestRetry = new RetryOptions { MaxRetries = 3 };
    });

var connectionString = builder.Configuration.GetConnectionString("SimulacrumDatabase")
    ?? throw new InvalidOperationException("Connection string 'SimulacrumDatabase' not found.");

builder.Services.AddInfrastructure(connectionString);

var app = builder.Build();

// 2. Configure the HTTP request pipeline with middleware and map endpoints.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        // UI needs to know where the OpenAPI endpoint (JSON API description) is
        options.SwaggerEndpoint("/openapi/v1.json", "Simulacrum API");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// 3. Start the server and listen for incoming HTTP requests.
app.Run();