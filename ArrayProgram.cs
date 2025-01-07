using System;
public class ArrayProgram
{
	// main method
	static void Main(String[] args)
	{
		int[] arr = { 8,5,3,1,12,0};
		//Console.WriteLine(arr.Length);
		//Console.WriteLine(arr[0] + arr[2]);

        Console.WriteLine("Initial Array --> ");
        for (int i = 0; i < arr.Length; i++) 
		{ 
			Console.WriteLine(arr[i]);
		}

		Console.WriteLine("Sorted Array --> ");
		SortArray(arr);
		FindMin(arr);
		FindMax(arr);
    }
	// Sorting method
    static void SortArray(int[] arr)
	{
		int temp, i, j;

		for (i = 0; i < arr.Length; i++)
		{
			for (j = i + 1; j < arr.Length; j++)
			{
				if (arr[i] > arr[j])
				{
					temp = arr[i];
					arr[i] = arr[j];
                    arr[j] = temp;
				}
			}
		}
        for (int k = 0; k < arr.Length; k++)
        {
            Console.WriteLine(arr[k]);
        }
    }
	// method to find minimum of the array
	static void FindMin(int[] arr)
	{
		int min = arr[0];
		foreach (int i in arr)
		{
			if (i < min)
			{
				min = i;
			}
		}
		Console.WriteLine("Smallest element in the array :\t" + min);
	}

    // method to find maximum of the array
    static void FindMax(int[] arr)
    {
        int min = arr[0];
        foreach (int i in arr)
        {
            if (i > min)
            {
                min = i;
            }
        }
        Console.WriteLine("Largest element in the array :\t" + min);
    }

}