using System.Text.Json;

string contents = File.ReadAllText("Weapon.json");

Weapon w = JsonSerializer.Deserialize<Weapon>(contents);
int damageSum = 0;
int numAttacks = 0;
string TempNumAttacks = "";

Console.WriteLine("How many attacks do you wanna make?");



while (!int.TryParse(TempNumAttacks, out numAttacks))
{
    TempNumAttacks = Console.ReadLine();
}

for (int i = 0; i < numAttacks; i++)
{
    int damage = w.Attack();
    Console.WriteLine($"+{damage}");
    damageSum += damage;
}

Console.WriteLine($"You did a total of {damageSum} points of damage");

Console.ReadLine();
