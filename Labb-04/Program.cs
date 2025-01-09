namespace Labb_04;

class Program
{
    private static List<Person> personer = new List<Person>();


    static void Main(string[] args)
    {

        Console.WriteLine("Listan för personer är nu skapad. Vi kan fortsätta med nästa steg!");


        bool körProgram = true;

        while (körProgram)
        {
            Console.WriteLine("\nVälj ett alternativ:");
            Console.WriteLine("1. Lägg till en person");
            Console.WriteLine("2. Visa alla personer");
            Console.WriteLine("3. Avsluta programmet");

            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    AddPerson();
                    break;
                case "2":
                    Console.WriteLine("Här kommer vi visa alla personer!");
                    Console.WriteLine("---------------------------------");
                    ListPersons();
                    break;
                case "3":
                    Console.WriteLine("Avslutar programmet...");
                    körProgram = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }



    // Metod för att lägga till en1 person
    static void AddPerson()
    {
        Console.WriteLine("\nLägg till en ny person:");

        try
        {
            // Namn
            Console.Write("Ange namn: ");
            string namn = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(namn)) throw new ArgumentException("Namn kan inte vara tomt.");

            // Kön
            Console.WriteLine("Ange kön (0=Kvinna, 1=Man, 2=IckeBinär, 3=Annan): ");
            if (!int.TryParse(Console.ReadLine(), out int könIndex) || könIndex < 0 || könIndex > 3)
            {
                throw new ArgumentException("Ogiltigt val för kön.");
            }
            Gender kön = (Gender)könIndex;

            // Hår
            Console.Write("Ange hårlängd: ");
            string hårLängd = Console.ReadLine();
            Console.Write("Ange hårfärg: ");
            string hårFärg = Console.ReadLine();
            Hair hår = new Hair(hårLängd, hårFärg);

            // Födelsedag
            Console.Write("Ange födelsedag (yyyy-mm-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime födelsedag))
            {
                throw new ArgumentException("Felaktigt format för födelsedag.");
            }

            // Ögonfärg
            Console.Write("Ange ögonfärg: ");
            string ögonfärg = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ögonfärg)) throw new ArgumentException("Ögonfärg kan inte vara tom.");

            // Lägg till personen i listan
            Person person = new Person(namn, kön, hår, födelsedag, ögonfärg);
            personer.Add(person);

            Console.WriteLine("\nPersonen har lagts till i listan!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Fel: {ex.Message}");
            Console.WriteLine("Försök igen.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ett oväntat fel inträffade: {ex.Message}");
            Console.WriteLine("Försök igen.");
        }
    }

    static void ListPersons()
    {
        if (personer.Count == 0)
        {
            Console.WriteLine("Det finns inga personer i listan.");
        }
        else
        {
            foreach (Person person in personer)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}      








