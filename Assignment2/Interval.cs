
using System;

internal class Interval
{
    private static void Main(string[] args)
    {
        bool blnVerified = false;
        Decimal decimalValue;
        do
        {
            Console.Write("Enter a real number: ");
            var userInput = Console.ReadLine();
            if (Decimal.TryParse(userInput, out decimalValue))
            {
                blnVerified = true;
            } else
            {
                Console.Write("Please enter a valid number.");
            }
        } while (!blnVerified);
        
        if (((decimalValue >= 1) && (decimalValue <= 3)) || ((decimalValue == -10) || (decimalValue == -2))) {
            Console.WriteLine("{0} x does belongs to I", decimalValue);
        } else
        {
            Console.WriteLine("{0} x does not belong to I", decimalValue);
        }
    }

}



