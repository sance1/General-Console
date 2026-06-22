using System;
using System.Collections.Generic;


public class Program : Test
{
    public static void Main()
    {
        Proses();

    }

    static void Proses()
    {
        List<string> data = AllData();         
		Console.WriteLine(string.Join(", ", data));
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
