using System;
using System.Collections.Generic;

class Program
{
	//this for pages logic change idxPages
    // static void Main()
    // {
		// List<string> result = Pages();
		// Console.WriteLine(string.Join(", ", result));
		// Console.ReadKey();
    // }
	static List<string> Pages()
	{
		List<string> data = names();		
		List<string> tenData = new List<string>();
		int idxPages = 3;
		int endPages = 10;
		int startPages = 1;
		int startLengthPages = 0;
		int endLengthPages = 4;
		endPages = endPages * idxPages;
		startPages = endPages - 10;
		startLengthPages = startLengthPages + idxPages;
		endLengthPages = endLengthPages + idxPages;
		for(int i = startPages; i < endPages; i++)
		{
			tenData.Add(data[i]);
		}
		for(int j = startLengthPages; j <= endLengthPages; j++ )
		{
			Console.Write(j);
		}
		Console.WriteLine("");
		return tenData;
	}
	static List<string> names()
	{
		List<string> allName = new List<string>{
			"Samce", "Naila", "Queen", "Aris", "Budi", "Chandra", "Dinda", "Eka", "Fahmi", "Gita", "Hadi", "Indah", "Joko", "Kevin", "Laras", "Maulana", "Nanda", "Olivia", "Putra", "Rania", "Santi", "Tono", "Utami", "Vian", "Wati", "Xavier", "Yanto", "Zahra", "Adit", "Bella", "Citra", "Doni", "Elisa", "Fandy", "Grace", "Hendra", "Irma", "Joni", "Kiki", "Lia", "Maman", "Nina", "Oki", "Panji", "Rere", "Soni", "Tika", "Umar", "Vina", "Wawan", "Yudi", "Zainal", "Agus", "Bambang", "Cici", "Dedi", "Endah", "Farhan", "Gani", "Hana", "Iwan", "Julia", "Koko", "Lulu", "Mira", "Niko", "Opik", "Prita", "Rian", "Sari", "Taufik", "Ulan", "Vero", "Winda", "Yoga", "Zaki", "Anwar", "Bunga", "Cecep", "Dewi", "Erwin", "Fitri", "Galih", "Hesti", "Indra", "Januar", "Kania", "Lucky", "Maya", "Noval", "Okta", "Putri", "Rendy", "Sila", "Teten", "Ujang", "Viki", "Wulan", "Yeyen", "Zul"
		};
		return allName;
	}
	static void Test1()
	{
		Console.WriteLine("Modified oke");
		List<int> arr = new List<int>{10,20,10,20,30};
		int result = Proses(5,arr);
		Console.WriteLine(result);
        Console.ReadKey();
	}
	static void start()
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

