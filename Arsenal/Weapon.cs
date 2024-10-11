using System.Text.Json.Serialization;

public class Weapon
{
    [JsonInclude]
    public String name;

    [JsonInclude]
    public int DamageMin = 10;

    [JsonInclude]
    public int DamageMax = 20;

    public int Attack()
    {
        return Random.Shared.Next(DamageMin, DamageMax);
    }
}

