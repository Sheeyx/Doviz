
int operationNum = 0;
 do
{
    Console.WriteLine();
    Console.WriteLine("This program will convert your money as follow!:");
    Console.WriteLine("1. Uzbek (so'm) => USD");
    Console.WriteLine("2. USD => Uzbek (so'm)");
    Console.WriteLine("3. Exit");
    Console.Write("Enter a number: ");

    try
    {
        operationNum = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    catch (FormatException formatException)
    {
        Console.WriteLine("The input is not in a correct format");
    }
    catch (OverflowException overflowException)
    {
        Console.WriteLine("Value is too large or too small, take a look data type.");
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }

    decimal exchangeRate;


    switch (operationNum)
    {
        case 1:
            Console.Write("Enter your exchange rate: ");
            exchangeRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter your budjet (Uzb so'm): ");
            decimal  Amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Your amount in usd is {Amount / exchangeRate}$ ");
            break;

        case 2:
            Console.Write("Enter your exchange rate: ");
            exchangeRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter your budjet (Uzb so'm): ");
            Amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Your amount in uzb so'm is {Amount * exchangeRate} so'm");
            break;

        case 3:
            Console.WriteLine("Thank you for using our application! ");
            break;

        default:
            Console.WriteLine("Entered wrong operation, try again!!!");
            break;
    }
} while (operationNum != 3);