using System;

public class EvenNumber
{
    public static void main(String[] args)
    {
      
        Console.Write("Find if given number is even");
       Console.WriteLine("Enter the number: ");
        int num1 = Console.ReadLine();
        String number = (num1 % 2 == 0) ? "Even" : "Odd";

        Console.Write("Entered number " + number);


    }
}
