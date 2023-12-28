using System;

class Lab05Zad13
{
    public static void Print(int[] a, int[] b)
    {
        // na 0.21 pkt

        var str = "";
        var last = 9999;

        for (var i = 0; i < a.Length; i++)
        {
            if (!Array.Exists(b, x => (x == a[i])) && last != a[i])
            {

                str += $"{a[i]}|";
                last = a[i];
            }
        }

        last = 9999;

        for (var i = 0; i < b.Length; i++)
        {
            if (!Array.Exists(a, x => (x == b[i])) && last != b[i])
            {

                str += $"{b[i]}|";
                last = b[i];
            }
        }

        if (str == "")
        {
            Console.WriteLine("empty");
        }
        else
        {
            var arr = str.Split("|");
            Console.WriteLine(string.Join(" ", arr));
        }
    }

    static void Ex3(string[] args)
    {
        var a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
        var b = new int[] { 0, 2, 2, 3, 4 };
        Print(a, b);
    }
}