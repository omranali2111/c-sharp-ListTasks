internal class Program
{
    private static void Main(string[] args)
    {
        int[] newArray = new int[10];
        Console.WriteLine("enter list of numbers:");

        task1(newArray);

    }

    public static void task1(IList<int> newArray)
    {
        /*
        1.Write a program that takes a list of integers as input and removes
            duplicate numbers, keeping only the unique elements. Implement a 
            method that accepts the list and returns a new list containing 
            only the unique elements in the original order.
        */
        int c = newArray.Count;
        for (int i = 0; i < c; i++)
        {
            try
            {
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        List<int> numbers = new List<int>();
       
        foreach (int i in newArray)
        {
            numbers.Add(i);
           
        }
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
}

