using System;

class Program
{
    static void Main(string[] args)
    {
       
        List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };

       
        Comparison<int> comparison = (x, y) =>
        {
           
            if (x < y)
                return 1;
            else if (x > y)
                return -1;
            else
                return 0;
        };
      
        numbers.Sort(comparison);
  
        Console.WriteLine("Llista ordenada:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
