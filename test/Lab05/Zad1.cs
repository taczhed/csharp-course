using System;

class Lab05Zad1
{
    public static void Print(int[] a, int[] b)
    {
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

    static void Zad(string[] args)
    {
        var a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
        var b = new int[] { 0, 2, 2, 3, 4 };
        Print(a, b);
    }
}