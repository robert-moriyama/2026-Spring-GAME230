// Question 1
Console.WriteLine("Question 1:");
int index1 = 1;

// Iterates from 1 to 5 (inclusive)
while (index1 <= 5)
{
    Console.Write(index1 + " ");
    index1++;
}


// Question 2
Console.WriteLine("\n\nQuestion 2:");
int index2 = 100;

// Iterates from 100 to 150 (inclusive)
while (index2 <= 150)
{
    Console.Write(index2 + " ");
    index2++;
}


// Question 3
Console.WriteLine("\n\nQuestion 3:");
int index3 = 0;

// Iterates for all even numbers from 0 to 100 (inclusive)
while (index3 <= 100)
{
    Console.Write(index3 + " ");
    index3 += 2;
}


// Question 4
Console.WriteLine("\n\nQuestion 4:");
int index4 = 20;

// Iterates from 20 to -20 (inclusive and descending [-20, -19, ..., 19, 20])
while (index4 >= -20)
{
    Console.Write(index4 + " ");
    index4--;
}


// Question 5
Console.WriteLine("\n\nQuestion 5:");
int index5 = 1;

// Iterates from 1 to 100 (inclusive and in multiples of 3 [1, 4, ..., 97, 100])
while (index5 <= 100)
{
    Console.Write(index5 + " ");
    index5 += 3;
}


// Question 6
Console.WriteLine("\n\nQuestion 6:");
int index6 = 1;

// Iterates from 1 to 1024 (inclusive and in powers of 2 [1, 2, ..., 512, 1024])
while (index6 <= 1024)
{
    Console.Write(index6 + " ");
    index6 *= 2;
}


// Question 7
Console.WriteLine("\n\nQuestion 7:");
string response;

// Runs indefinitely until the user wants the loop to stop or there is invalid input
do
{
    Console.WriteLine("Do you want the loop to stop? (yes/no)");
    response = Console.ReadLine();
    // Converts the user's input to all lowercase (this helps simplify the conditionals below)
    response = response.ToLower();

    if (response == "yes" || response == "y")
    {
        // Stops the loop
        break;
    }
    else if (response == "no" || response == "n")
    {
        // Goes to the next iteration
        continue;
    }
    else
    {
        // Stops the loop and notifies the user of invalid input
        Console.Write("Invalid input! Stopping loop...");
        break;
    }
} while (true);


// Question 8
Console.WriteLine("\n\nQuestion 8:");
int index8 = 0;
bool isTrue = true;

// Iterates 100 times and alternates between "True" and "False"
while (index8 < 100)
{
    if (isTrue)
    {
        // Prints "True " if isTrue is true
        Console.Write("True ");
    }
    else
    {
        // Prints "False " if isTrue is false
        Console.Write("False ");
    }
    
    // Reverses the value of isTrue at the end of every iteration (if isTrue is true, it will switch to false)
    isTrue = !isTrue;
    index8++;
}


// Question 9
Console.WriteLine("\n\nQuestion 9:");
int index9 = 1;
bool isEven = false;

// Iterates 20 times and alternates between even and odd (same idea as question 8)
while (index9 <= 20)
{
    if (isEven)
    {
        // Prints that the number is even if isEven is true
        Console.Write(index9 + " is even ");
    }
    else
    {
        // Prints that the number is odd if isEven is false
        Console.Write(index9 + " is odd ");
    }
    
    // Reverses the value of isEven at the end of every iteration (if isEven is true, it will switch to false)
    isEven = !isEven;
    index9++;
}


// Question 10
Console.WriteLine("\n\nQuestion 10:");

int index10 = 0;
string[] arr = new string[] {"once", "upon", "a", "midnight", "dreary"};

// Iterates across the entire array arr and adds a space after each word
while (index10 < arr.Length)
{
    Console.Write(arr[index10] + " ");
    index10++;
}


// Bonus
Console.WriteLine("\n\nBonus:");

int indexBonus = 1;

// Iterates from 1 to 45 (inclusive)
while (indexBonus <= 45)
{
    if ((indexBonus % 3 == 0) && (indexBonus % 5 == 0))
    {
        // Prints "fizzbuzz " if indexBonus is a multiple of 3 and 5 (remainder of 0 for both)
        Console.Write("fizzbuzz ");
    }
    else if (indexBonus % 3 == 0)
    {
        // Prints "fizz " if indexBonus is only a multiple of 3
        Console.Write("fizz ");
    }
    else if (indexBonus % 5 == 0)
    {
        // Prints "buzz " if indexBonus is only a multiple of 5
        Console.Write("buzz ");
    }
    else
    {
        // Prints the number if indexBonus is not a multiple of 3 and 5
        Console.Write(indexBonus + " ");
    }
    
    indexBonus++;
}