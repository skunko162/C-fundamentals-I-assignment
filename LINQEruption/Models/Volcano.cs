#pragma warning disable CS8618
namespace LINQEruption;

public class Eruption
{
    public string Volcano { get; set; }
    public int Year { get; set; }
    public string Location { get; set; }
    public int ElevationInMeters { get; set; }
    public string Type { get; set; }
    public Eruption(string volcano, int year, string location, int elevationInMeters, string type)
    {
        Volcano = volcano;
        Year = year;
        Location = location;
        ElevationInMeters = elevationInMeters;
        Type = type;
    }

}
