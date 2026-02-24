using System;
using System.ComponentModel.Design;

class Program
{
    enum Range
    {
        Min = 50,
        Max = 100,
        Size = 10
    }
    
    static void Main()
    {
        int[] numbers = new int[(int)Range.Size]; // A range is like size up the 10 to (1,10)
        int sum = 0;
        int num;
        for (int i = 1; i < numbers.Length; i++)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out num))

            if (num >= (int)Range.Min && num <= (int)Range.Max)
            {
                numbers[i] = num;
                sum += num;
                
                
                
                if (num >= 74)
                {
                    Console.WriteLine($"You Passed in {i} quarter");
                
                }
                else if (num <= 75)
                {
                    Console.WriteLine($"You Fail in {i} quarter");  
                
                }
                        
            }

            else
            {
                Console.WriteLine("Invalid! Enter 50-100 only.");
                i--; // repeat same index
            }
            
          }
          
       
            double average = (double)sum / numbers.Length;

        Console.WriteLine("Average = " + average);
    }
}