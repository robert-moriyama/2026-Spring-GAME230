string stringA, stringB; // Variables for the two values the user inputs (string type)
double doubleA, doubleB; // Variables for the two values the user inputs (converted into double type)
string operation; // Variable for the operation the user inputs (string type)

// First number (A)
Console.WriteLine("What is your first number?");
stringA = Console.ReadLine();
doubleA = double.Parse(stringA);

// Second number (B)
Console.WriteLine("What is your second number?");
stringB = Console.ReadLine();
doubleB = double.Parse(stringB);

// Operation
Console.WriteLine("What operation do you want to perform? Type 'addition', 'subtraction', 'multiplication', or 'division'.");
operation = Console.ReadLine();