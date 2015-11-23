using System;
using Domain;

namespace Спорщики
{
    class Program
    {
        static void Main()
        {
            int number;
            var jay = new Jay();
            var silentBob = new SilentBob();
            var numbertron = new Numbertron();
            numbertron.NewNumber += jay.FetchNewNumber;
            numbertron.NewNumber += silentBob.FetchNewNumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Сколько чисел требуется для решения спора?");
            } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
            do
            {
                numbertron.Generate();
                number--;
            } while (number > 0);
            if (jay.Score > silentBob.Score) Console.WriteLine(jay.Name);
            else if(jay.Score < silentBob.Score) Console.WriteLine(silentBob.Name);
            else Console.WriteLine("DRAW");
            Console.ReadKey();
        }
    }
}
