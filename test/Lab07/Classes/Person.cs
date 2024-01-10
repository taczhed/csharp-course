using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Lab07.Classes
{
    public class Person
    {
        public string firstName;
        public string familyName;
        public int age;

        public Person(string firstName, string familyName, int age)
        {
            FirstName = firstName;
            FamilyName = familyName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({Age})";
        }

        public string FirstName
        {
            get => firstName;
            private set => firstName = FormatName(value);
            
        }

        public string FamilyName
        {
            get => familyName;
            private set => familyName = FormatName(value);
        }

        public int Age
        {
            get => age;
            private set => age = FormatAge(value);
        }

        public void modifyFirstName(string name)
        {
            firstName = FormatName(name);
        }

        public void modifyFamilyName(string name)
        {
            familyName = FormatName(name);
        }

        public void modifyAge(int _age)
        {
            age = FormatAge(_age);
        }

        private string FormatName(string name)
        {
            name = name.Replace(" ", "");

            char[] tempName = new char[name.Length];

            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    throw new ArgumentException("Wrong name!");
                }

                if (i == 0)
                {
                    tempName[0] = char.ToUpper(name[0]);
                    continue;
                }

                tempName[i] = char.ToLower(name[i]);
            }

            return new string(tempName);
        }

        private int FormatAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }

            return age;
        }

    }
}
