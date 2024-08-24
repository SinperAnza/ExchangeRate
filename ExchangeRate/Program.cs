using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to currency converter!");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Enter the currency (USD, Euro, GBP, Yen, Rupee) or 'Exit' to quit: ");
            string currency = Console.ReadLine();

            if (currency.Equals("Exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye");
                break;
            }

            Console.WriteLine("Enter Amount: ");
            double amount;
            if (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount. Please enter a numeric value.");
                continue;
            }

            double exchangeRate = GetExchangeRate(currency);
            if (exchangeRate == 0)
            {
                Console.WriteLine("Unsupported currency.");
                continue;
            }

            double value = amount * exchangeRate;
            Console.WriteLine($"The value is ZAR {value}");
            Console.WriteLine();
        }
    }

    static double GetExchangeRate(string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return 20;
            case "EURO":
                return 30;
            case "GBP":
                return 21;
            case "YEN":
                return 1 / 8.4; 
            case "RUPEE":
                return 1 / 4.62; 
            default:
                return 0; 
        }
    }
}
