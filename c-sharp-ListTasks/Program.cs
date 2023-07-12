using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[] newArray = new int[11];
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(5);
        numbers.Add(4);
        task1(numbers);

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
    public static void task2()
    {
        /*
        2.Implement a program that takes a list of strings as 
            input and performs the following operations: Remove
            all elements that contain a specific character specified
            by the user. Sort the remaining elements in ascending order.
            Return the modified list. 
        */



    }
}

