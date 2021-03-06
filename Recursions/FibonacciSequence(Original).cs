/* C# Program to find the Fibonacci Numbers for a series of n numbers
 * Source: W3Resource
 * Source Author: 
 * Source URL: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-10.php
 * Date Accessed: 04/05/2019
 */

using System;

class RecExercise10
{
    public static int FindFibonacci(int n)
    {
	int p = 0;
	int q = 1;
	for (int i = 0; i < n; i++)
	{
	    int temp = p;
	    p = q;
	    q = temp + q;
	}
	return p;
    }

    static void Main()
    {
        Console.WriteLine("\n\n Recursion : Find the Fibonacci numbers for a n numbers of series :");
		Console.WriteLine("-----------------------------------------------------------------------");
	
		Console.Write(" Input number of terms for the Fibonacci series : ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n The Fibonacci series of {0} terms is : ",n1);
	    for (int i = 0; i < n1; i++)
	        {
	            Console.Write("{0} ",FindFibonacci(i));
	        }
	Console.ReadKey();
    }
}
