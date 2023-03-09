using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0) {
            Console.WriteLine("Число {0} является чётным.", number);
        } else {
            Console.WriteLine("Число {0} не является чётным.", number);
        }
    }
}

