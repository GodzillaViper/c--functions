using System;
using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;

internal class Program
{   
    private static void Main(string[] args)
    {   
        // uppgift 1
        // int sekAmount = 1000;
       
        // double yenAmount = Converter(sekAmount);

        // Console.WriteLine($"{sekAmount} SEK är {yenAmount} JPY");

        // uppgift 2 
        // Console.Write("Enter rectangle base: ");
        // int rectBase = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter rectangle base: ");
        // int rectHeight = Convert.ToInt32(Console.ReadLine());
        // WriteOnceBlock(rectBase, rectHeight);

        // uppgift 3 
        LucasNumber(10);

    }

    static double Converter(int amount, double rate = 15.86)
    {
        return amount * rate;
    }

    static void WriteOnceBlock( int rectBase, int rectHeight) { 
        Console.WriteLine($"Area:  {rectBase * rectHeight}");
        Console.WriteLine($"Circumference: {(rectBase + rectHeight)* 2}");
    }

    static void LucasNumber(int length, int numOne=2, int numTwo=1) {
        if (length <= 0) {
            return;
        }

        Console.WriteLine(numOne);
        Console.WriteLine(numTwo);
        int sum = numOne + numTwo;
        length -= 1;

        LucasNumber(length, sum, sum + numTwo);
    }   
}

