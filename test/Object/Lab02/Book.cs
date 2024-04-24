using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Object.Lab02
{
    public abstract class Book
    {
        public string title { get; set; }
        public string[] authors { get; set; }
        public int pages { get; set; }
        public string pageFormat { get; set; }
        public bool isForAdult { get; set; }
        public decimal price { get; set; }

        public abstract void ShowBasicInforamtions();
        public virtual decimal CountPriceOfSinglePage()
        {
            return price / pages;
        }

    }

    class Magazine : Book
    {
        public string issn { get; set; }
        public int yearlyNo { get; set; }
        public bool isColored { get; set; }

        public override void ShowBasicInforamtions()
        {
            Console.WriteLine($"About Magazine: {title} (No. {yearlyNo}) (ISSN: {issn}) by {String.Join(", ", authors)})");
        }
    }

    class Guide : Book
    {
        public string isbn { get; set; }
        public string[] topics { get; set; }
        public string[] langs { get; set; }
        public bool isCertified { get; set; }

        public override void ShowBasicInforamtions()
        {
            Console.WriteLine($"About Guide: {title} ({isbn}) by {String.Join(", ", authors)}" + (isCertified ? " - Certified" : ""));
        }
    }
}