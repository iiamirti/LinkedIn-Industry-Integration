using SP.Directory.Data; // For LinkedInIndustryDto
using YourAppName.Models; // For DropdownItem
using System.Text.Json;   // For JSON deserialization
using System.Collections.Generic;
using System.Linq;

namespace YourAppName.Services
{
    public class LinkedInIndustryService : ILinkedInIndustryService
    {
        private List<DropdownItem> _cachedIndustries;

        public LinkedInIndustryService()
        {
            // Helper function to create indented display name
            // This logic mirrors the frontend's getIndentedName for consistency
            string GetIndentedName(string fullLabel)
            {
                var parts = fullLabel.Split(" > ");
                var indentation = new string('\u00A0', (parts.Length - 1) * 4); // Unicode for non-breaking space
                return $"{indentation}{parts.Last()}";
            }

            try
            {
                // 1. Deserialize the raw JSON into LinkedInIndustryDto objects
                var rawIndustries = JsonSerializer.Deserialize<List<LinkedInIndustryDto>>(LinkedInIndustryData.IndustriesJson);

                _cachedIndustries = new List<DropdownItem>();

                // Add the default "Select an Industry" option first
                _cachedIndustries.Add(new DropdownItem
                {
                    Value = -1,
                    Text = "Select an Industry",
                    FullHierarchy = "Select an Industry",
                    Description = "Please select an industry from the list."
                });

                if (rawIndustries != null)
                {
                    // 2. Map LinkedInIndustryDto to DropdownItem
                    foreach (var dto in rawIndustries)
                    {
                        _cachedIndustries.Add(new DropdownItem
                        {
                            Value = dto.Id,
                            Text = GetIndentedName(dto.Label), // Indented display name
                            FullHierarchy = dto.Label,          // Full original hierarchy for search
                            Description = dto.Description
                        });
                    }

                    // 3. Sort the actual industry items by their full hierarchy (label)
                    // Exclude the "Select an Industry" option from sorting
                    var sortedIndustries = _cachedIndustries
                                            .Where(item => item.Value != -1)
                                            .OrderBy(item => item.FullHierarchy)
                                            .ToList();

                    // Reconstruct the list with "Select an Industry" at the top
                    var finalIndustries = new List<DropdownItem>();
                    finalIndustries.Add(_cachedIndustries.First(item => item.Value == -1)); // Add the default option back
                    finalIndustries.AddRange(sortedIndustries); // Add sorted actual industries

                    _cachedIndustries = finalIndustries;
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON deserialization error in LinkedInIndustryService: {ex.Message}");
                _cachedIndustries = new List<DropdownItem> { new DropdownItem { Value = -1, Text = "Data Error (JSON)", FullHierarchy = "Data Error", Description = "There was an error loading the industry data due to invalid JSON." } };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error in LinkedInIndustryService: {ex.Message}");
                _cachedIndustries = new List<DropdownItem> { new DropdownItem { Value = -1, Text = "Data Error (General)", FullHierarchy = "Data Error", Description = "An unexpected error occurred while loading industries." } };
            }
        }

        public IEnumerable<DropdownItem> GetIndustries()
        {
            return _cachedIndustries; // Return the cached list of DropdownItems
        }
    }
}
