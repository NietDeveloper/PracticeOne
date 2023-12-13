using System;
namespace PracticeOne
{
    class programm
    {
     static void Main()
    {
        // Doira yuzini va uzunligini topish
        Console.Write("Enter radius: ");
        string radiusInString = Console.ReadLine()!;
        int radius = Convert.ToInt32(radiusInString);
        Console.WriteLine($"S={Math.PI*radius*radius}, L={2*Math.PI*radius}");

        // Valyuta konverti
        Console.Write($"qiymati=");
        string qiymatInString = Console.ReadLine()!;
        double qiymat = Convert.ToDouble(qiymatInString);
        Console.Write("kurs=");
        string kursToString = Console.ReadLine()!;
        double kurs = Convert.ToDouble(kursToString);
        Console.WriteLine($"{qiymat*kurs}");

        Console.WriteLine("Enter your year:");
        string yearInString = Console.ReadLine()!;
        int year = Convert.ToInt32(yearInString);
        Console.WriteLine($"The day your live:{(2023-year)*365}");
    }
    }
}

