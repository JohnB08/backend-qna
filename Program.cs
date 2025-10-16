// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var nameAndJobTable = new Dictionary<string/* Dette er datatypen til nøkkelen / index i dictionariet. */, string /* Dette er datatypen til verdien bak nøkkel.  */>();

nameAndJobTable.Add("John", "Veileder");

var jobForJohn = nameAndJobTable["John"];

Console.WriteLine(jobForJohn);

string[] produkter = {
            "Fanta", "Cola", "Cola Zero", "Solo", "Urge",
            "Kjeks", "Lunsj", "Valnøtter", "Hasselnøtter", "Melk"
        };
int[] priser = {

            25, 25, 25, 25, 25,  // Drikke

            20, 30 , 40, 30, 25, // Snacks
        };

var produktOgPrisTable = new Dictionary<string, int>()
{
    ["fanta"] = 25,
    ["cola"] = 25,
    ["hasselnøtter"] = 40
};

var prisForProdukt = produktOgPrisTable["cola"];

Console.WriteLine(prisForProdukt);

string[] days = ["monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"];

char[][] chars = [
    ['a', 'b', 'c'],
    ['d', 'e', 'f'],
    ['g', 'h', 'i']
    ];


for (int i = 0; i < days.Length; i++)
{
    Console.WriteLine(days[i]);

    var dailyCharacter = chars[i % chars.Length][0];
    Console.WriteLine(dailyCharacter);
}

Console.WriteLine(Console.ReadLine());

var nameDaysGreetingAndAgeDictionary = new Dictionary<string, (string day, string greeting, int age)>()
{
    ["Mona Lisa"] = ("monday", "What a smile!", 28),
    ["Al Pacino"] = ("tuesday", "Loved the donut commercial!", 85)
};

Console.WriteLine("Who do you want a greeting for?");
var input = Console.ReadLine();

if (nameDaysGreetingAndAgeDictionary.TryGetValue(input, out (string day, string greeting, int age) value))
{
    Console.WriteLine(value.greeting);
}
else
{
    Console.WriteLine("Not a valid name!");
}