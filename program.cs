var builder = WebApplication.CreateBuilder(args);

...

// Register your service as a Singleton because the data is loaded once from a static source.
// This is efficient as the data won't change during the application's lifetime.
builder.Services.AddSingleton<ILinkedInIndustryService, LinkedInIndustryService>();

...

app.Run();
