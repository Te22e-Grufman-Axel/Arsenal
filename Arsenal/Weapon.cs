using System.Text.Json.Serialization;
public class Weapon
{
  [JsonInclude]
  public string Name;

  [JsonInclude]
  public int MinDamage = 30;

  [JsonInclude]
  public int MaxDamage = 50;

  public int Attack()
  {
    return Random.Shared.Next(MinDamage, MaxDamage);
  }
}