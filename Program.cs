//reverse a number:
/*
Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int reversed = 0;
while (num != 0)
{
    int digit = num % 10;
    reversed = reversed * 10 + digit;
    num /= 10;
}
Console.WriteLine(reversed);*/

/*
int num = 5;
        int fact = 1;
        while (num > 0)
        {
            fact = fact * num;
            num--;
        }
        Console.Write(fact);*/

/* Exchanging variables
int x = 20;
        int y = 30;
        int z = x;
        x = y;
        y = z;
        Console.WriteLine(x);
        Console.Write(y);
*/

//with out variables
/*
 int x = 20;
        int y = 30;
        x = x + y;
        y = x - y;
        x = x - y;
        Console.Write(x);
        Console.Write(y);
*/

/*sum of digits of a number
int num = 12345;
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        Console.Write(sum);*/

//sum of n natural numbers
/*  Console.WriteLine("enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            sum += i;
        }
        Console.Write(sum);
*/

/*code for palindrome*/

/*int num = 12345;
        int reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        if (num == reversed)
        {
            Console.Write("palindrome");
        }
        else
        {
            Console.WriteLine("not a palindrome");
        }
    }
*/

/*febnocii*/
/*
using System;
using System.ComponentModel;
class code
{
    static void Main()
    {
        int num = 5;
        int a = 0;
        int b = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 2; i < num; i++)
        {
            int next = a + b;
            a = b;
            b = next;
        }
    }
}*/

//code to print prime number in a range
/*
using System;
using System.ComponentModel;
class code
{
    static void Main()
    {
        Console.WriteLine("enter a number");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter a number");
        int end = Convert.ToInt32(Console.ReadLine());
        for (int num = start; num <= end; num++)
        {
            if (num <= 1) continue;

            bool isprime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime)
            {
                Console.Write(num+" ");
            }
            
        }
    }
}*/
//To check wether a number is prime or not
/*
int num = Convert.ToInt32((Console.ReadLine()));
if (num <= 1)
{
    Console.WriteLine("its not a prime");
}
bool isprime = true;
for (int i = 2; i <= Math.Sqrt(num); i++)
{
    if (num % i == 0)
    {
        isprime = false;
        break;
    }
}
if (isprime)
{
    Console.WriteLine("its prime");
}
else
{
    Console.WriteLine("its not a prime");
}*/