Calculation();
void Summation()
{
    Console.WriteLine("Please enter your first number for summation process.");
    string num1String = Console.ReadLine();
    double num1 = double.Parse(num1String);
    Console.WriteLine("Please enter your second number for summation process.");
    string num2String = Console.ReadLine();
    double num2 = double.Parse(num2String);

    double summation = num1 + num2;
    Console.WriteLine("Summation of your number is " + summation + "\n");
}

void Substraction()
{
    Console.WriteLine("Please enter your first number for substraction process.");
    string num1String = Console.ReadLine();
    double num1 = double.Parse(num1String);
    Console.WriteLine("Please enter your second number for substraction process.");
    string num2String = Console.ReadLine();
    double num2 = double.Parse(num2String);

    double substraction = num1 - num2;
    Console.WriteLine("Summation of your number is " + substraction + "\n");
}

void Multiplying()
{
    Console.WriteLine("Please enter your first number for multiplying process.");
    string num1String = Console.ReadLine();
    double num1 = double.Parse(num1String);
    Console.WriteLine("Please enter your second number for multiplying process.");
    string num2String = Console.ReadLine();
    double num2 = double.Parse(num2String);

    double multiplying = num1 * num2;
    Console.WriteLine("Multiplying of your number is " + multiplying + "\n");
}

void Dividing()
{
    Console.WriteLine("Please enter your first number for dividing process.");
    string num1String = Console.ReadLine();
    double num1 = double.Parse(num1String);
    Console.WriteLine("Please enter your second number for dividing process.");
    string num2String = Console.ReadLine();
    double num2 = double.Parse(num2String);

    double dividing = num1 / num2;
    Console.WriteLine("Dividing of your number is " + dividing + "\n");
}

void Calculation()
{
    Console.WriteLine("Select which calculation you will perform.\n\tFor summation press '+'\n\tFor substraction press '-'\n\tFor multiplying press '*'\n\tFor dividing press '/'\n");
    char userPerform = char.Parse(Console.ReadLine());

    switch (userPerform)
    {
        case '+':
            Summation();
            break;

        case '-':
            Substraction();
            break;

        case '*':
            Multiplying();
            break;

        case '/':
            Dividing();
            break;

        default:
            Console.WriteLine("Unknown process...\n");
            break;
    }

    Console.WriteLine("Do you want to continue to the use calculator\n\t For Yes: 'Y' , For No: 'N'");
    string userContinue = Console.ReadLine();
    Console.WriteLine();

    if (userContinue == "Y" || userContinue == "y")
        Calculation();
}

Console.ReadKey();
