using VillaAPI.Models.DTOs;

namespace VillaAPI.Data
{
    /// <summary>
    /// The mocked data storage for villas
    /// </summary>
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new()
        {
            new() { Id = 1, Name = "Pool view" },
            new() { Id = 2, Name = "Beach view" },
        };
    }
}
