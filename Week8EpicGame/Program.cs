string folderPath = @"C\data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));




//string[] heroes = { "Batman", "Luke Skywalker", "Lara Croft", "Ciri" };
//string[] villains = { "Joker", "Darth Vader", "Sauron", "Dr.Doom", "orc" };
string[] weapon = { "batarang", "Dragon Slayer", "lightsaber", "katana", "acid pistol", "a gun"};

string hero = GetRandomValueFromArray(heroes); 
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world");


static string GetRandomValueFromArray(string[] somearray)
{
    Random rnd = new Random();
    int randomindex = rnd.Next(0, somearray.Length );
    string randomStringFromArray = somearray[randomindex];
    return randomStringFromArray;
}