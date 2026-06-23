using System;
using System.Collections.Generic;

public class Start
{
	public static void Start1()
	{
		for(int i = 0; i < 5; i++)
		{
			Console.Write(i);
			for(int j = i + 1; j<5; j++)
			{
				Console.Write(j);
			}
			Console.WriteLine();
		}
	}
	public static void Start2()
	{
		Console.WriteLine();
		for(int i = 0; i < 5; i++)
		{
			Console.Write(i);
			if(i>0){
				for(int j = i + 1; j <= i + i; j++ )
				{
					Console.Write(j);
				}
			}			
			Console.WriteLine();
		}
	}
	public static void Start3()
	{
		for(int i = 4 ; i >=0; i--)
		{
			Console.Write(i);
			for(int j = i -1; j >= 0;j--)
			{
				Console.Write(j);
			}
			Console.WriteLine();
		}
	}
	public static void Start4()
	{
		for(int i = 0; i < 5; i++)
		{
			Console.Write(i);
			for(int j = i +1 ; j < 5; j++)
			{
				Console.Write("-");
			}	
			for(int k = 0; k <= i*2; k++)
			{
				Console.Write(k);
			}
			Console.WriteLine();
		}
	}
}