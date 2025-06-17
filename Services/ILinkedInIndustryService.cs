using YourAppName.DtoDto; // Use your main application's Models namespace

namespace YourAppName.Services
{
    public interface ILinkedInIndustryService
    {
        IEnumerable<DropdownItem> GetIndustries();
    }
}
