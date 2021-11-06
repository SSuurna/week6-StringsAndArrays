using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm käsib kasutajal sisestada ees- ja perekonnanimi
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit ja perekonnanimes {lastName.Length} sümbolit.");

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Eesnimi on pikem.");
            }
            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Perekonnanimi on pikem.");
            }
            else
            {
                Console.WriteLine("Ees- ja perekonnanimi on võrdsed.");
            }
        }
    }
}
