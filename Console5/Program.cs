using System;

namespace Console5
{
    class Program
    {
        static void Main(string[] args)
        {  


        // Task 1//


            System.Console.WriteLine("Task 1");
            System.Console.WriteLine("");
            
            System.Console.Write("Enter the size of array: ");
            int.TryParse(Console.ReadLine(), out var arrSize);
            int[] arr = new int [arrSize];
            int sum = 0;
            int cou = 0;

            for (int i = 0; i < arrSize; i++)
            {
            System.Console.Write($"Enter the array element for index {i}: ");
            int.TryParse(Console.ReadLine(), out arr[i]);

            }

            int max = arr[0];
            int min = arr[0];

            System.Console.WriteLine("");
                    
            for (int i = 0; i < arrSize; i++)
            {
            sum += arr[i];
            cou ++;

            if (arr[i] < min) 
            {
            min = arr[i];
            }

 
            if (arr[i] > max)
            {
            max = arr[i];
            }

            if (arr[i] % 2 == 0)
            {
            System.Console.WriteLine(arr[i]);
            }
            
            
            }
            double arith = sum/cou;
            System.Console.WriteLine($"The maximum array value is {max}");
            System.Console.WriteLine($"The minimum array value is {min}");
            System.Console.WriteLine($"The sum of array elements is {sum}");
            System.Console.Write($"The arithmetic mean of array elements is: {arith}");

            Console.WriteLine("\nEnter any key to continue: "); 
            Console.ReadKey();
            System.Console.WriteLine("");
            System.Console.WriteLine("");

        
        // Task 2 //

            System.Console.WriteLine("Task 2");
            System.Console.WriteLine("");

            System.Console.Write("Enter the size of array: ");
            int.TryParse(Console.ReadLine(), out var arrSize2);
            int[] arr2 = new int [arrSize2];


            for (int i = 0; i < arrSize2; i++)
            {
            System.Console.Write($"Enter the array element for index {i}: ");
            int.TryParse(Console.ReadLine(), out arr2[i]); 
            }

            System.Console.WriteLine("");

            for ( int i = arrSize2-1; i >= 0; i-- ){
                    Console.Write(" "+ arr2[i]); 
                }

            Console.WriteLine("\nEnter any key to continue: ");
            Console.ReadKey();

            System.Console.WriteLine("");
            System.Console.WriteLine("");


        // Task 3 //

            System.Console.WriteLine("Task 3");
            System.Console.WriteLine("");

            System.Console.Write("Enter the size of array: ");
            int.TryParse(Console.ReadLine(), out var N);
            System.Console.Write("Array elements are: ");
            int[] arr3 = new int[N];
            
            for (int i = 0; i < N; i++)

            {
            arr3[i] = new Random().Next(2,100);;
            Console.Write(arr3[i] + " ");
            }

        
            System.Console.WriteLine("");
            System.Console.Write("Enter index: ");
            int.TryParse(Console.ReadLine(), out var index);
            System.Console.Write("Enter count: ");
            int.TryParse(Console.ReadLine(), out var count);

            int newArraySize = index + count;
            int diff = newArraySize - arr3.Length;

            if (newArraySize > arr3.Length)
            {

            for (int i = index; i < N; i++)
            {
            System.Console.Write($"{arr3[i]} "); 
            }

            for (int j = N; j < diff + N; j++)
            {
            System.Console.Write("1 ");
            }
            }
           

            else
            {
                for (int i = index; i < newArraySize; i++)
                {
                System.Console.Write($"{arr3[i]} "); 
                }
            }
            
            
        }
    }
}
