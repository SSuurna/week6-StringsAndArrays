using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga - 0
            //programm asendab kõik 'a' tähed samas lauses 4-ga

            string Panic = "Don't Panic";

            Panic = Panic.Replace('o', '0');
            Panic = Panic.Replace('a', '4');

            Console.WriteLine(Panic);
        }
    }
}
