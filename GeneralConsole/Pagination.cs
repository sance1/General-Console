using System;
using System.Collections.Generic;

public class Pagination
{
    public static void Proses()
    {
        List<string> data = AllData();         
		List<string> showData = new();
		//Change this pagination to see the result
        int pagePagination = 3;
		int startDt = 0;
		int lengthDt = 10;
		lengthDt = (lengthDt * pagePagination);
		startDt = lengthDt - 10; 
		for(int i = startDt; i<lengthDt; i++)
		{
			showData.Add(data[i]);
		}
		Console.WriteLine(string.Join(", ", showData));
    }

    static List<string> AllData()
    {
        // Berisi 102 nama unik yang dideklarasikan langsung
        return new List<string> 
        { 
            "sance", "quin", "naila", "budi", "andi", "citra", "dewi", "eka", "fajar", "gita",
            "hendra", "indah", "joko", "kartika", "lestari", "mulyono", "nina", "omega", "putra", "ratna",
            "surya", "taufik", "utami", "vivi", "wawan", "xandra", "yanto", "zara", "agus", "bambang",
            "chandra", "dedi", "elly", "farhan", "grace", "haris", "irma", "jamal", "kevin", "lisa",
            "maulana", "novi", "olivia", "panji", "qori", "rudi", "sari", "tanti", "usman", "valen",
            "winda", "xavier", "yuni", "zainal", "ari", "bagus", "cindy", "doni", "erika", "fadli",
            "guntur", "hana", "iwan", "julia", "kurniawan", "lutfi", "mega", "nur", "oki", "putri",
            "rizky", "sofian", "tri", "umar", "vera", "wahyu", "yusuf", "zaki", "ade", "bintang",
            "daniel", "endah", "fany", "gilang", "herman", "ika", "joni", "kiki", "lia", "mira",
            "nizar", "oscar", "prima", "reza", "sinta", "tomi", "unang", "viona", "willy", "yoga",
            "zulkifli", "aditya"
        };
    }
}