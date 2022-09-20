double a, b;
bool stillMore;
do
{
    Console.WriteLine("Welcome to Calculator: Enter your option (1-4)");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Sub");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.Write("Enter your option: ");
    string answer = Console.ReadLine();

    Console.Write("Enter 1st No: ");
    string received1 = Console.ReadLine();

    while (!Double.TryParse(received1, out a))
    {
        Console.WriteLine("Not valid, try again: ");
        received1 = Console.ReadLine();
    }

    Console.Write("Enter 2nd No: ");
    string received2 = Console.ReadLine();
    while (!Double.TryParse(received2, out b))
    {
        Console.WriteLine("Not valid, try again: ");
        received2 = Console.ReadLine();
    }
    double c = 0;

    switch (answer)
    {
        case "1":
            c = a + b;
            Console.WriteLine($"add : {c}");
            break;
        case "2":
            c = a - b;
            Console.WriteLine($"sub : {c}");
            break;
        case "3":
            c = a * b;
            Console.WriteLine($"multiply : {c}");
            break;
        case "4":
            c = a / b;
            Console.WriteLine($"divide : {c}");
            break;
    }
    Console.Write("More number to calculate? (Y/N): ");
    string choice = Console.ReadLine().ToUpper();
    if (choice.StartsWith("Y"))
        stillMore = true;
    else
        stillMore = false;
} while (stillMore);
