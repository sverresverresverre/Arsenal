using System.Text.Json;





string json = File.ReadAllText("weapon.json");

Weapon h = JsonSerializer.Deserialize<Weapon>(json);

Console.WriteLine(json);
Console.ReadLine();
