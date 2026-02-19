string stringA, stringB; // Variables for the two values the user inputs (string type)
double doubleA, doubleB, answer; // Variables for the two values the user inputs (converted into double type)
string operation; // Variable for the operation the user inputs (string type)

// Operation user input
Console.WriteLine("What operation do you want to perform? Type 'addition', 'subtraction', 'multiplication', or 'division'.");
operation = Console.ReadLine();

// First number (A) user input
Console.WriteLine("What is your first number?");
stringA = Console.ReadLine();
doubleA = double.Parse(stringA);

// Second number (B) user input
Console.WriteLine("What is your second number?");
stringB = Console.ReadLine();
doubleB = double.Parse(stringB);

// Conditionals to check the operation
if (operation == "addition")
{
    answer = doubleA + doubleB;
    Console.WriteLine(doubleA + " + " + doubleB + " = " + answer);
}
else if (operation == "subtraction")
{
    answer = doubleA - doubleB;
    Console.WriteLine(doubleA + " - " + doubleB + " = " + answer);
}
else if (operation == "multiplication")
{
    answer = doubleA * doubleB;
    Console.WriteLine(doubleA + " * " + doubleB + " = " + answer);
}
else if (operation == "division")
{
    // Conditional to check if the second number is 0, since you can not divide anything by 0
    if (doubleB == 0)
    {
        Console.WriteLine("You cannot divide by zero!");
    }
    else
    {
        answer = doubleA / doubleB;
        Console.WriteLine(doubleA + " / " + doubleB + " = " + answer);
    }
}
else
{
    Console.WriteLine("Invalid operation!");
}