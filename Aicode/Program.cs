// See https://aka.ms/new-console-template for more information
using System;


// A method to check if a number is prime or not
static bool IsPrime(int n)
{
    // Corner cases
    if (n <= 1) return false;
    if (n <= 3) return true;

    // This is checked so that we can skip 
    // middle five numbers in below loop
    if (n % 2 == 0 || n % 3 == 0) return false;

    for (int i = 5; i * i <= n; i = i + 6)
        if (n % i == 0 )
            return false;

    return true;
}



// Get the input from the user
Console.WriteLine("Enter the first number:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int second = int.Parse(Console.ReadLine());

// Swap the numbers if first is larger than second
if (first > second)
{
    int temp = first;
    first = second;
    second = temp;
}

// Print the prime numbers between the two numbers
Console.WriteLine("The prime numbers between {0} and {1} are:", first, second);
for (int i = first; i <= second; i++)
{
    if (IsPrime(i))
    {
        Console.WriteLine(i);
    }
}
Console.Read();





