string folderPath = @"C:\data";
string heroFile = "heroes.txt";
string villainFail = "villains.txt";

string[] heros = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFail));



//string[] heros = {"Ironman", "Superman", "Spiderman", "Batman"};
//string[] villains = { "Doctor Octopus", "Red Skull", "Doctor Doom", "Mephisto", "Galactus" };


string[] weapon = { "Cosmic Cubes", "The Ultimate Nullifier", "All-Black The Necrosword", "The Darkhold", "The Black Vortex" };

string hero = GetRandomValueFromArray(heros);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Randomly chosen hero is: {hero}" );
Console.WriteLine($"He's heros randomly chosen weapon is: {heroWeapon}");



string villain = GetRandomValueFromArray(villains);
string villanWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Randomly chosen hero is: {villain}");
Console.WriteLine($"He's villans randomly chosen weapon is: {villanWeapon}");

static string GetRandomValueFromArray(string[] someArray) 
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
