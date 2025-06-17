// Add necessary usings at the top of Program.cs
using YourAppName.Services; // Ensure this is correct
using YourAppName.Models; // Ensure this is correct
using YourAppName.Data; // Ensure this is correct
using SP.Directory.Data; // For LinkedInIndustryDto if used directly in Program.cs (not strictly needed here)


var builder = WebApplication.CreateBuilder(args);

...

// Register your service as a Singleton because the data is loaded once from a static source.
// This is efficient as the data won't change during the application's lifetime.
builder.Services.AddSingleton<ILinkedInIndustryService, LinkedInIndustryService>();

...

app.Run();
