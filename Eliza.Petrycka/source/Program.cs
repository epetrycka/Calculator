using System.Text.Json;
using intern25;

string inputFile = Path.Combine(Directory.GetCurrentDirectory(), "input.json");
string outputFile = "output.txt";

if (!File.Exists(inputFile))
{
    Console.WriteLine("Nie znaleziono pliku input.json");
    return;
}

string jsonString = File.ReadAllText(inputFile);

Dictionary<string, MathExpObject> expressionsDict = new Dictionary<string, MathExpObject>();

try
{
    var rawDict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonString);

    if (rawDict != null)
    {
        foreach (var entry in rawDict)
        {
            try
            {
                MathExpObject obj = JsonSerializer.Deserialize<MathExpObject>(entry.Value) ?? new MathExpObject();
                expressionsDict[entry.Key] = obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Pominięto {entry.Key} z powodu błędu: {ex.Message}");
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Błąd deserializacji pliku JSON: " + ex.Message);
}

if (expressionsDict.Count == 0)
{
    Console.WriteLine("Brak poprawnych danych w pliku JSON.");
    return;
}

Dictionary<string, double> results = new Dictionary<string, double>();

foreach (var entry in expressionsDict)
{
    string key = entry.Key;
    MathExpObject op = entry.Value;

    try
    {
        double result = Calculations.PerformCalculation(op);
        results[key] = result;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Error in {key}: {ex.Message}");
    }
}

var sortedResults = results.OrderBy(kv => kv.Value).ToList();

using (StreamWriter writer = new StreamWriter(outputFile))
{
    foreach (var kvp in sortedResults)
    {
        writer.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}

Console.WriteLine("Wyniki zapisano pomyślnie");