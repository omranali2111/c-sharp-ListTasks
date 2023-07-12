using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
       
        List<int> numbers = new List<int>();
        Console.WriteLine(" Enter numbers ");
        for (int i = 0; i < 10; i++)
        { 
            
            int ListInput = int.Parse(Console.ReadLine());
            numbers.Add(ListInput);

         }

            task1(numbers);
        

        Console.WriteLine("=============================================");
        List<string> text = new List<string>();
        Console.WriteLine(" Enter String ");
        for (int i = 0; i < 5; i++)
        {

            string ListInput = Console.ReadLine();
            text.Add(ListInput);

        }
        Console.Write("Enter a character to remove from the list: ");
        char target = Console.ReadLine()[0];
        task2(text, target);
        */

        Console.WriteLine("=============================================");

        List<int> numbers1 = new List<int>();
        Console.WriteLine(" Enter 5 numbers ");
        for (int i = 0; i < 5; i++)
        {

            int ListInput1 = int.Parse(Console.ReadLine());
            numbers1.Add(ListInput1);

        }

        int maxValue=task3(numbers1);
        Console.WriteLine(maxValue);
        



    }

    public static void task1(List<int> numbers)
    {
        /*
        1.Write a program that takes a list of integers as input and removes
            duplicate numbers, keeping only the unique elements. Implement a 
            method that accepts the list and returns a new list containing 
            only the unique elements in the original order.
        */
       
        Console.WriteLine("Original list:");
        foreach (int number in numbers)
        {
           Console.Write(number+" ");
        }
        List<int> uniqueList = numbers.Distinct().ToList();

        Console.WriteLine("\nList with duplicates removed:");

        foreach (int number in uniqueList)
        {
            Console.Write(number + " ");
        }

    }
    public static List<string> task2(List<string> textList,char target)
    {
        /*
        2.Implement a program that takes a list of strings as 
            input and performs the following operations: Remove
            all elements that contain a specific character specified
            by the user. Sort the remaining elements in ascending order.
            Return the modified list. 
        */
        textList.RemoveAll(item => item.Contains(target));
        textList.Sort();

        Console.WriteLine("Modified list:");
        foreach (string item in textList)
        {
            Console.WriteLine(item);
        }
        textList.Sort();// Sort the modified list in ascending order
        Console.WriteLine("the modified list :");
        return textList;

    }

    /*
    3. Write a program that finds the maximum value 
        in a list of integers.Implement a method that
     accepts the list as input and returns the maximum value.
    */

    public static int task3(List<int> numbers)
    {

        Console.Write("maximum value in the list is:");
        return numbers.Max();


       
    }


}

