double Result, number1, number2, limit;
bool stillMore;

Console.WriteLine("Welcome to Calculator: Enter your option (1-4)");
Console.WriteLine("1. Add");
Console.WriteLine("2. Sub");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide");
do
{

    Console.Write("Enter your option: ");
    string received = Console.ReadLine();
    while (!Double.TryParse(received, out limit) || limit > 4 || limit < 1)
    {
        Console.Write("Not valid, try again: ");
        received = Console.ReadLine();
    }

    Console.Write("Enter 1st No: ");
    received = Console.ReadLine();

    while (!Double.TryParse(received, out number1))
    {
        Console.Write("Not valid, try again 1st number: ");
        received = Console.ReadLine();
    }

    Console.Write("Enter 2nd No: ");
    received = Console.ReadLine();
    while (!Double.TryParse(received, out number2))
    {
        Console.Write("Not valid, try again 2nd number: ");
        received = Console.ReadLine();
    }
    
    switch (limit)
    {
        case 1:
            Result = number1 + number2;
            Console.WriteLine("Add : " + Result);
            break;
        case 2:
            Result = number1 - number2;
            Console.WriteLine("Sub : " + Result);
            break;
        case 3:
            Result = number1 * number2;
            Console.WriteLine("Multiply : " + Result);
            break;
        case 4:
            Result = number1 / number2;
            if (number2 == 0)
                Console.WriteLine("You can not denominate with 0");
            else
                Console.WriteLine("divide : " + Result);
            break;
        default:
            Console.WriteLine("Not valid, try again");
        break;
    }
    Console.Write("More number to calculate? (Y/N): ");
    string choice = Console.ReadLine().ToUpper();
    if (choice.StartsWith("Y"))
        stillMore = true;
    else
        stillMore = false;
} while (stillMore);
