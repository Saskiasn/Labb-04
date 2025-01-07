namespace Labb_04;

class Program
{
    static void Main(string[] args)
    {
        // Skapa en instans av Hair
        Hair personHair = new Hair("Långt", "Blond");

        // Skapa en instans av Person
        Person person = new Person(
            "Karl Johansson",     // Namn
            Gender.Man,           // Kön
            personHair,           // Hår
            new DateTime(1985, 3, 25), // Födelsedag
            "Grön"                // Ögonfärg
        );
        Console.WriteLine(person.name);

        //Person person = new Person();

        // Skriv ut information om personen
        Console.WriteLine(person.ToString());

    }





}

