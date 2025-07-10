// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting date information

// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprilFools:d}");

// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprilFools:D}");

// TODO: 'f' Full date, short time
Console.WriteLine($"{AprilFools:f}");

// TODO: 'F' Full date, long time
Console.WriteLine($"{AprilFools:F}");

// TODO: 'g' General date and time
Console.WriteLine($"{AprilFools:g}");

// TODO: 'G' General date and time
Console.WriteLine($"{AprilFools:G}");

// TODO: Format using a specific CultureInfo
Console.WriteLine(AprFools.ToStrings("d", CultureInfo.CreateSpecificCulture("de-De")));

// TODO: Defining custom date and time formats
Console.WriteLine($"{AprFools:dddd, MMMM, d yyyy}");
Console.WriteLine($"{AprFools:ddd, h:mm:ss tt}");
Console.WriteLine{$"{AprFools:MMM, d yyyy}"};