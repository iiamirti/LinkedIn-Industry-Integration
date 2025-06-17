namespace YourAppName.Models // Use your actual application namespace
{
    public class LinkedInIndustryDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = string.Empty; // Use string.Empty for non-nullable strings
        public string Hierarchy { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    // OPTIONAL (FOR FUTURE OR FRONTEND USAGE)
    // This is still useful for what the frontend expects for dropdown items
    public class DropdownItem
    {
        public int Value { get; set; }
        public string Text { get; set; } = string.Empty;
        public string FullHierarchy { get; set; } = string.Empty; // To store original hierarchy for display/sorting
        public string Description { get; set; } = string.Empty; // To pass description to frontend
    }
}
