/*system is like a tool box where c# keeps all common tools...
it is a name space that contains many basic tools and functions u r programme needs*/
/*System.Linq contains special tools called LINQ methods (Language Integrated Query).
/*Examples inside System:
System.Console → lets you use Console.WriteLine.
System.String → defines how strings work.
System.Math → has math functions like Math.Sqrt.
Why we write using System; at the top
So you can use Console.WriteLine directly instead of typing System.Console.WriteLine every time.
*/
/*These methods (ToArray(), Where(), Select(), etc.) help you work with collections like arrays, lists, or strings easily.*/
/*In short: System.Linq 
a set of helper functions for searching, filtering, and transforming data in collections.*/

using System;
using System.Linq;
// class Reverse_of_str
// {
//     static void Main()
//     {
//         string name = "Hello World";
//         var arr = name.ToArray();
//         for (int i = name.Length - 1; i >= 0; i--)
//         {
//             Console.Write(arr[i]);
//         }
//     }
// }

//another way to reverse a string:
/*string name = "Hello World";
for (int i = name.Length - 1; i >= 0; i--)
{
    Console.Write(name[i]);
}*/

/*to reverse a sentence*/
/*
string name = "HelloWorld is a basic string";
string[] arr = name.Split(' ');
for (int i = arr.Length - 1; i >= 0; i--)
{
    Console.Write(arr[i] + " ");
}
string csv = string.Join(",", arr); */


//for user input
/*class reverse
{
    static void Main()
    {
        Console.WriteLine("enter a string");
        string str = Console.ReadLine();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
    }
}*/

//palindrome check
/*class Palindrome
{
    static void Main()
    {
        Console.WriteLine("enter a string");
        string name = Console.ReadLine();
        string rev = "";
        for (int i = name.Length - 1; i >= 0; i--)
        {
            rev += name[i];
        }
        if (name == rev)
        {
            Console.WriteLine("its a palindrome");
        }
        else
        {
            Console.WriteLine("its not a palindrome");
        }
    }
}*/


/*string name = "bharath";  // b h a r a t h
// Index:              0 1 2 3 4 5 6

Console.WriteLine(name.Length);    // 7 (total characters)
Console.WriteLine(name.Length - 1);// 6 (last valid index)
*/

//frequency of characters in a string.
//individual charcter manullay compared.
/*/ string name = "bbarath";
// char nam = name[0];
// int character = 0;
// for (int i = 0; i <= name.Length-1; i++)
// {
//     if (nam == name[i])
//     {
//         character++;
//     }
// }
// Console.WriteLine($"no of {name[0]} chars are:" + character);
*/

//to find frequency of characters:
/*using System;
class counting
{
    static void Main()
    {
        string name = "bharath";
        string lower = name.ToLower();
        string counted = "";

        for (int i = 0; i <= name.Length; i++)
        {
            char current = name[i];

            if (current == ' ' || counted.Contains(current))
                continue;

            int count = 0;
            for (int j = 0; j <= name.Length; j++)
            {
                if (name[j] == current) 
                count++;
            }
            Console.WriteLine($"current:{current}");
            counted += current;
        }
    }
}*/

//to print only unique elements or to remove duplicate elements
/*
using System;
using System.Runtime.CompilerServices;
class counting
{
    static void Main()
    {
        String name = "bharath";
        string lower = name.ToLower();
        string counted = " ";
        foreach (char c in name)
        {
            if (!counted.Contains(c) && c != ' ')
            {
                counted += c;
            }
        }
           Console.WriteLine(counted);
    }
}*/

//only to print duplicates

/*using System;
using System.Runtime.CompilerServices;
class counting
{
    static void Main()
    {
        String name = "bharath";
        string lower = name.ToLower();
        string counted = " ";
        foreach (char c in name)
        {
            if (counted.Contains(c) && c != ' ')
            {
                Console.WriteLine(c);
            }
            else
            {
                counted += c;
            }
        }
    }
}*/

/*
using System;
class longestword
{
    static void Main()
    {
        string sent = "I am learning front end development";
        string[] arr = sent.Split(' ');
        string longestword = "";

        foreach (string word in arr)
        {
            if (word.Length > longestword.Length)
            {
                longestword = word;
            }
        }
        int l = longestword.Length;
        Console.WriteLine($"lonest word is {longestword} : {l}");
    }
}*/

//to print longest word in a string:
/*string sentence = "I am learning csharp";
string[] words = sentence.Split(' ');
Console.WriteLine(words.Length);*/

/*Count words in a string
string name = "bharath is learning programming";
int count = 0;
string[] arr = name.Split(' ');
foreach (string i in arr)
{
    count++;
}
Console.WriteLine(count);*/


//nullorempty means to safety check wether string contains any null/charas.
//to capitalize each word in a string
/*string name = "bharat is learning";
string[] arr = name.Split(' ');
for (int i = 0; i <= name.Length; i++)
{
    if (!string.IsNullOrEmpty(arr[i]))
    {
        arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1);
    }
}
Console.WriteLine(string.Join(" ",arr));*/

//find first non repeating character in string...
/*
using System;
class unique
{
    static void Main()
    {
        string str = "swiss";
        for (int i = 0; i <= str.Length; i++)
        {
            if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
            {
                Console.WriteLine($"first non repeating char:" + str[i]);
                return;
            }
            Console.WriteLine("no non repeating character found");
        }
    }
}*/

//to check wether a string is anagram or not:
// using System;
// class program
// {
//     static void Main()
//     {
//         string str1 = "silent";
//         string str2 = "listen";
//         str1 = str1.Replace(" ", "").ToLower();
//         str2 = str2.Replace(" ", "").ToLower();
//         char[] arr1 = str1.ToCharArray();
//         char[] arr2 = str2.ToCharArray();
//         Array.Sort(arr1);
//         Array.Sort(arr2);
//         if (new string(arr1) == new string(arr2))
//         {
//             Console.WriteLine("its a anagram");
//         }
//         else
//         {
//             Console.WriteLine("its not an anagram");
//         }
//     }
// }

//y return
/*In C#, the return statement is used inside a method to send a value back to the code that called the method.*/
/*using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class sum
{
    public int ADD(int x, int y)
    {
        return x + y;
    }
}

class code
{
    static void Main()
    {
        sum obj = new sum();
        int result = obj.ADD(10, 20);
        Console.WriteLine(result);
    }
}*/

//to print vowels, consonants and count and print them:
// string name = "bharath is learning to code";
// string[] voe = { "a", "e", "i", "o", "u" };
// foreach (char i in name)
// {
//     string lower = i.ToString().ToLower();
//     Boolean isvowel = false;
//     foreach (string j in voe)
//     {
//         if (lower == j)
//         {
//             isvowel = true;
//             break;
//         }
//     }
//     if (!isvowel && i != ' ')
//     {
//         Console.WriteLine(i);
//         //output consonants:
//     }
// }

// string name = "bharath is learning to code";
// string[] voe = { "a", "e", "i", "o", "u" };
// foreach (char i in name)
// {
//     string lower = i.ToString().ToLower();
//     Boolean isvowel = false;
//     foreach (string j in voe)
//     {
//         if (lower == j)
//         {
//             isvowel = true;
//             break;
//         }
//     }
//     if (isvowel)
//     {
//         Console.WriteLine(i);
//         //output vowels...
//     }
// }

// string name = "bharath is learning to code";
// string[] voe = { "a", "e", "i", "o", "u" };
// int vows = 0;
// int cons = 0;
// foreach (char i in name)
// {
//     if (i == ' ')
//         continue;
//     string lower = i.ToString().ToLower();
//     Boolean isvowel = false;
//     foreach (string j in voe)
//     {
//         if (lower == j)
//         {
//             isvowel = true;
//             break;
//         }
//     }
//     if (isvowel)
//     {
//         vows++;
//     }
//     else
//     {
//         cons++;
//     }
// }
// Console.WriteLine($"no of vowels are{vows}");
// Console.WriteLine($"no of consonants are{cons}");