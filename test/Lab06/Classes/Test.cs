using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Lab06.Classes
{
    class Test
    {

        /* Using
         * var random = new Test("Andrzej", 21);
         random.WrtieAge();
         random.Foot = 44;
         */

        public Test(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string name;
        private int age;
        private int foot;

        public int Foot
        {
            get { return foot; }
            set { 
                if (value > 0)
                {
                    foot = value;
                } 
            }
        }


        public void WrtieAge ()
        {
            Console.WriteLine(age);
        }
    }

}
