using System.Collections.Generic;
public class Resort
{
    public string Name {get; set;} = default!;
    public double Latitude {get; set;}
    public double Longitude {get; set;}
}

public static class ResortData
{
    public static Resort BearValley { get; } = new()
    {
        Name = "Bear Valley",
        Latitude = 38.4926,
        Longitude = -120.0067
    };

    public static Resort ChinaPeak { get; } = new()
    {
        Name = "China Peak",
        Latitude = 37.2297,
        Longitude = -119.1583
    };

    public static Resort DodgeRidge { get; } = new()
    {
        Name = "Dodge Ridge",
        Latitude = 38.1898,
        Longitude = -119.9559
    };

    public static Resort MountainHigh { get; } = new()
    {
        Name = "Mountain High",
        Latitude = 34.2361,
        Longitude = -117.6467
    };

    public static List<Resort> GetResorts() =>
        new() { BearValley, ChinaPeak, DodgeRidge, MountainHigh };
}