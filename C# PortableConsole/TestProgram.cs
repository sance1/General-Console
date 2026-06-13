using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
		int n = 6;
		for(int i = 1; i <= n; i++)
		{
			Console.WriteLine(i);
			 string spasi = new string('-', n - i);
			 string kar = new string('x', i*2-1);
			Console.WriteLine(spasi+kar);
		}
		Console.WriteLine(" ");
		Console.WriteLine("ok");
		string ok = new string('t', 6);
		Console.WriteLine(ok);
		Console.ReadKey();
    }
	static void Test1()
	{
		Console.WriteLine("Modified oke");
		List<int> arr = new List<int>{10,20,10,20,30};
		int result = Proses(5,arr);
		Console.WriteLine(result);
        Console.ReadKey();
	}
	static int Proses(int n, List<int> arr)
	{
		int result = 0;
		for(int i = 0; i < n; i++)
		{
			for(int j = i + 1; j < n; j++)
			{
					if(arr[i] == arr[j] && arr[i] != 200 ){
						result += 1;
						arr[i]= 200;
						arr[j] = 200;
					}
			}
			
		}
		return result;
	}
}

