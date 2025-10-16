// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var nameAndJobTable = new Dictionary<string/* Dette er datatypen til nøkkelen / index i dictionariet. */, string /* Dette er datatypen til verdien bak nøkkel.  */>();

nameAndJobTable.Add("John", "Veileder");

var jobForJohn = nameAndJobTable["John"];

Console.WriteLine(jobForJohn);


/* For å passe på at to dataverdier i to samlinger er linket sammen, har dere kanskje prøvd å bruke to arrays, så synkronisere indexen for hver item." */
string[] produkter = {
            "Fanta", "Cola", "Cola Zero", "Solo", "Urge",
            "Kjeks", "Lunsj", "Valnøtter", "Hasselnøtter", "Melk"
        };
int[] priser = {

            25, 25, 25, 25, 25,  // Drikke

            20, 30 , 40, 30, 25, // Snacks
        };


/* En mer nyttig datatype for dette, ville vært et dictionary. Et dictionary kobler to verdier sammen, i et Key/Value par.
Hvor du kan bruke nøkkelen for å hente ut verdien.  */
var produktOgPrisTable = new Dictionary<string, int>()
{
    ["fanta"] = 25,
    ["cola"] = 25,
    ["hasselnøtter"] = 40
};

var prisForProdukt = produktOgPrisTable["cola"];

Console.WriteLine(prisForProdukt);



/* Et annet triks vi så på, var å synkronisere to samlinger av forskjellig lengde. 
Vi hadde ett array på lengde 7, og ett array på lengde 3. 

For å garantere i en loop, som loopet over days arrayet også kunne hente et gyldig element i chars arrayet, 
brukte vi modulo operatoren %.
Vi kan se for oss at modulo operatoren henter ut rest verdien av en dele operasjon.  se nedenfor for mer info*/

string[] days = ["monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"];

char[][] chars = [
    ['a', 'b', 'c'],
    ['d', 'e', 'f'],
    ['g', 'h', 'i']
    ];


for (int i = 0; i < days.Length; i++)
{
    Console.WriteLine(days[i]);

/* Her bruker vi modulo operatoren for å passe på at iteratoren vår, alltid også er en gyldig index av char.

Vi kan se for oss at % betyr følgende:
    1. ta i og del den på char.length.
    2. ignorer den hele verdien, men finn resten. 
        (hvis i er 3 og lengden på chars er 3, er det ingen rest verdi. resultatet er 0, eller første index i chars.)
        (hvis i er 5 og lengden på chars er 3, har vi en hel 3, og 2 til overs. resultatet er 2, eller tredje index i chars.)
    */
    var dailyCharacter = chars[i % chars.Length][0];
    Console.WriteLine(dailyCharacter);
}

Console.WriteLine(Console.ReadLine());


/* Her ser vi at datatypene knyttet til dictionaries kan være svært komplisert. Her definerer vi en trupple, med verdier som representerer dager, en greeting og en alder.  */
var nameDaysGreetingAndAgeDictionary = new Dictionary<string, (string day, string greeting, int age)>()
{
    ["Mona Lisa"] = ("monday", "What a smile!", 28),
    ["Al Pacino"] = ("tuesday", "Loved the donut commercial!", 85)
};

/* Vi har mange gode hjelpemetoder for å bruke dictionaries, bl.a. kan vi prøve å bruke en nøkkel, og hente ut en verdi. 
På samme måte som vi kan bruke TryParse, kan vi bruke TryGetValue for å prøve en nøkkel, og se om det er en verdi der. 
Vi kan bruke den i programflyt på samme måte som TryParse.  */

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