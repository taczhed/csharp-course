using test.Object.Lab01;
using System;
using test.Object.Lab02;

// 4.7.2 .net

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var magazine = new Magazine { 
                title = "Czasopimo - Pediatria 2024", 
                authors = new string[] { "prof. Tomasz Nowak", "dr. Anna Annowska" }, 
                pages = 34, 
                pageFormat = "A5", 
                isForAdult = false, 
                price = 120, 
                issn = "202-202" 
            };

            var guide = new Guide { 
                title = "Pediatria - Podręcznik", 
                authors = new string[] { "prof. Tomasz Nowak" }, 
                pages = 235, pageFormat = "A4", 
                isForAdult = true, 
                price = 560, 
                isbn = "NSD-3556", 
                langs = new string[] { "PL", "EN" } 
            };

            magazine.ShowBasicInforamtions();
            guide.ShowBasicInforamtions();

            Thread.Sleep(10000);
        }
    }

}
