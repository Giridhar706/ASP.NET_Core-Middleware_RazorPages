var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 1. Error Handling Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
}
app.MapGet("/error", () => "A custom error occurred. Please try again.");

// 2. Security Middleware (HTTPS and CSP)
app.UseHttpsRedirection();
app.Use(async (context, next) =>
{
    context.Response.Headers.Append("Content-Security-Policy", "default-src 'self'");
    await next();
});

// 3. Custom Logging Middleware
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response Status: {context.Response.StatusCode}");
});

// 4. Serve Static Files
app.UseStaticFiles();

app.Run();