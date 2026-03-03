// Question 1
Console.WriteLine("Question 1:");
int index1 = 1;

while (index1 <= 5)
{
    Console.Write(index1 + " ");
    index1++;
}


// Question 2
Console.WriteLine("\n\nQuestion 2:");
int index2 = 100;

while (index2 <= 150)
{
    Console.Write(index2 + " ");
    index2++;
}


// Question 3
Console.WriteLine("\n\nQuestion 3:");
int index3 = 0;

while (index3 <= 100)
{
    Console.Write(index3 + " ");
    index3 += 2;
}


// Question 4
Console.WriteLine("\n\nQuestion 4:");
int index4 = 20;

while (index4 >= -20)
{
    Console.Write(index4 + " ");
    index4--;
}


// Question 5
Console.WriteLine("\n\nQuestion 5:");
int index5 = 1;

while (index5 <= 100)
{
    Console.Write(index5 + " ");
    index5 += 3;
}


// Question 6
Console.WriteLine("\n\nQuestion 6:");
int index6 = 1;

while (index6 <= 1024)
{
    Console.Write(index6 + " ");
    index6 *= 2;
}


// Question 7
Console.WriteLine("\n\nQuestion 7:");
bool isTrue = false;
string response;

do
{
    Console.WriteLine("Do you want the loop to stop?");
    response = Console.ReadLine();
    response = response.ToLower();

    if (response == "yes")
    {
        isTrue = true;
    }
    else if (response == "no")
    {
        isTrue = false;   
    }
    else
    {
        Console.Write("Invalid input!");
    }
} while (!isTrue);


// Question 8
Console.WriteLine("\n\nQuestion 8:");
int index8 = 0;

while (index8 < 100)
{
    if (index8 % 2 == 0)
    {
        Console.Write("True ");
    }
    else
    {
        Console.Write("False ");
    }

    index8++;
}


// Question 9
Console.WriteLine("\n\nQuestion 9:");
int index9 = 1;

while (index9 <= 20)
{
    if (index9 % 2 == 0)
    {
        Console.Write(index9 + " is even ");
    }
    else
    {
        Console.Write(index9 + " is odd ");
    }

    index9++;
}


// Question 10
Console.WriteLine("\n\nQuestion 10:");

int index10 = 0;
string[] arr = new string[] {"once", "upon", "a", "midnight", "dreary"};

while (index10 < arr.Length)
{
    Console.Write(arr[index10] + " ");
    index10++;
}


// Bonus
Console.WriteLine("\n\nBonus:");

int indexBonus = 1;

while (indexBonus <= 45)
{
    if ((indexBonus % 3 == 0) && (indexBonus % 5 == 0))
    {
        Console.Write("fizzbuzz ");
    }
    else if (indexBonus % 3 == 0)
    {
        Console.Write("fizz ");
    }
    else if (indexBonus % 5 == 0)
    {
        Console.Write("buzz ");
    }
    else
    {
        Console.Write(indexBonus + " ");
    }
    
    indexBonus++;
}