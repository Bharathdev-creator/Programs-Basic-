/*finding a largest element in an array,
 smallest
 reversing an array
 find duplicates in an array*/

// int[] num = { 10, 20, 30, 40, 50 };
// int largest = num[0];
// foreach (int i in num)
// {
//     if (i > largest)
//     {
//         largest = i;
//     }
// }
// Console.WriteLine(largest);

// int[] num = { 10, 20, 30, 40, 55 };
// int smallest = num[0];
// foreach (int i in num)
// {
//     if (i < smallest)
//     {
//         smallest = i;
//     }
// }
//Console.WriteLine($"smallest element is {smallest}");

//to find the second largest element in a n array:
/*int[] arr = {10,20,30,40,50,70};
int largest = arr[0];
int secondlargest = int.MinValue;

foreach (int i in arr)
{
    if (i > largest)
    {
        secondlargest = largest;
        largest = i;
    }
    else if (secondlargest > i && i != largest)
    {
        secondlargest = i;
    }
}
Console.WriteLine(secondlargest);*/

/*to sort an array in ascending order*/
/*
int[] arr = { 30, 50, 60, 10, 20 };
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
foreach(int num in arr) {
    Console.Write(num + " ");
}

foreach (int i in arr)
{
    Console.Write(i+" "); 
}*/

/*
int[] arr = { 30, 50, 60, 10, 20 };
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
foreach(int num in arr) {
    Console.Write(num + " ");
}
*/

//To print duplicates:
// using System;
// using System.Collections.Generic;
// class array
// {
//     static void Main()
//     {
//         int[] num = { 10, 20, 10, 20, 30, 50 };
//         List<int> templist = new List<int>();
//         foreach (int i in num)
//         {
//             templist.Add(i);
//         }
//         int[] num2 = num.ToArray();
//         for (int j = 0; j < num.Length; j++)
//         {
//             for (int k = j + 1; k < num2.Length; k++)
//             {
//                 if (num[j] == num2[k])
//                 {
//                     Console.WriteLine(num[j]);
//                     break;
//                 }
//             }
//         }
//     }
// }

// //Remove duplicates from an array:
// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.IO.Compression;
// class dup
// {
//     static void Main()
//     {
//         int[] num = { 10, 20, 20, 40, 10, 50, 60 };
//         List<int> unique = new List<int>();
//         for (int i = 0; i < num.Length; i++)
//         {
//             bool isduplicate = false;
//             for (int j = 0; j < unique.Count; j++)
//             {
//                 if (num[i] == unique[j])
//                 {
//                     isduplicate = true;
//                     break;
//                 }
//             }
//             if (!isduplicate)
//             {
//                 unique.Add(num[i]);
//             }
//         }
//         Console.WriteLine(unique);
//         foreach (int value in unique)
//         {
//             Console.WriteLine(value);
//         }
//     }
// }

//How to reverse an array:
// using System;
// using System.Collections.Generic;
// class Programa
// {
//     static void Main()
//     {
//         int[] num = { 10, 20, 30, 40, 50 };
//         List<int> number = new List<int>();

//         // Reverse the array
//         for (int i = num.Length - 1; i >= 0; i--)
//         {
//             number.Add(num[i]);
//         }

//         int[] num2 = number.ToArray();

//         // Print reversed elements
//         for (int j = 0; j < num2.Length; j++)
//         {
//             Console.WriteLine(num2[j]);
//         }

//         // Print the list contents in one line
//         Console.WriteLine("List contents: " + string.Join(", ", number));
//     }
// }

//How to merge two arrays:
/*
int[] arr1 = { 10, 20, 30, 40, 50 };
int[] arr2 = { 60, 70, 80, 90, 100 };
int[] merged = arr1.Concat(arr2).ToArray();
foreach (int i in merged)
{
    Console.Write(i+ " ");
}*/

/*
string[] names = { "a", "b", "c" };
Console.Write(names[2].Replace("c", "d"));
*/