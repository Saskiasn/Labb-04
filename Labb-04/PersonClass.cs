using System;
using static Labb_04.Program;

namespace Labb_04
{
    public enum Gender
    {
        Kvinna,
        Man,
        IckeBinär,
        Annan
    }

    public struct Hair
    {
        public string HairLenght { get; set; }
        public string HairColor { get; set; }

        public Hair(string hairlenght, string haircolor)
        {
            HairLenght = hairlenght;
            HairColor = haircolor;
        }

        public override string ToString()
        {
            return $"Hårlängd: {HairLenght}, Haircolor: {HairColor}";
        }
    }

    public class Person
    {
        // Egenskaper
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public Hair Hair { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Eyecolor { get; private set; }

        // Konstruktor
        public Person(string name, Gender gender, Hair hair, DateTime birthday, string eyecolor)
        {
            Name = name;
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            Eyecolor = eyecolor;
        }

        // ToString-metod
        public override string ToString()
        {
            return $"Namn: {Name}\n" +
                   $"Kön: {Gender}\n" +
                   $"Hår: {Hair}\n" +
                   $"Födelsedag: {Birthday:yyyy-MM-dd}\n" +
                   $"Ögonfärg: {Eyecolor}";
        }
    }
}

