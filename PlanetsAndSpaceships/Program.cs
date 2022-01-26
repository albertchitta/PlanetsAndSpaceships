// See https://aka.ms/new-console-template for more information

List<string> planetList = new List<string>() { "Mercury", "Mars" };

planetList.Add("Jupiter");
planetList.Add("Saturn");

List<string> newPlanetList = new List<string>() { "Uranus", "Neptune" };

planetList.AddRange(newPlanetList);

planetList.Insert(1, "Venus");
planetList.Insert(2, "Earth");
planetList.Add("Pluto");

List<string> rockyPlanets = new List<string>();
rockyPlanets = planetList.GetRange(0, 4);

Console.WriteLine("Rocky Planets:");
foreach (var planet in rockyPlanets)
{
    Console.WriteLine(planet);
}

planetList.Remove("Pluto");

Dictionary<string, string> spacecraftList = new Dictionary<string, string>();

spacecraftList.Add("Mercury", "Mariner, MESSENGER");
spacecraftList.Add("Venus", "Mariner, Venera");
spacecraftList.Add("Mars", "Viking, Opportunity, Curiosity");


Console.Write("\nAll Planets:");
foreach (var planet in planetList)
{
    Console.Write($"\n{planet}");
    foreach (var spacecraft in spacecraftList)
    {
        if (spacecraft.Key == planet)
        {
            Console.Write($": {spacecraft.Value}");
        }
    }
}