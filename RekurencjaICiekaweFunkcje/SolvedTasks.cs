using System.ComponentModel.Design;

namespace RekurencjaICiekaweFunkcje;

public class SolvedTasks
{
    //Zad 1
    private static int Fib(int n)
    {
        if (n == 1 || n == 0)
        {
            return 1;
        }
        else
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }

    public void DisplayNthFibonacciNumber(int n)
    {
        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += Fib(i).ToString() + " ";
        }
        result += "\n";
        Console.WriteLine(result);
    }

    //Zad 2
    private static int CustomSeries(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 2;
        }
        else if (n % 2 != 0)
        {
            return CustomSeries(n - 1) * 2;
        }
        else
        {
            return CustomSeries(n - 1) + 2;
        }
    }
    public void DisplayCustomSeries(int n)
    {
        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += CustomSeries(i).ToString() + " ";
        }
        result += "\n";
        Console.WriteLine(result);
    }

    //Zad 3
    public void MinMaxArray(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        string result = "";
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i] + " ";
        }
        Console.WriteLine(result);
        Console.WriteLine("Najmniejsza wartość w tablicy: " + min);
        Console.WriteLine("Największa wartość w tablicy: " + max);
    }
}