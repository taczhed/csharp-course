using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test.Lab06.Classes
{
    public class Person
    {

        private string familyName;
        private string firstName;
        private DateTime birthday;

        public Person(string familyName, string firstName, DateTime birthday)
        {
            FamilyName = familyName;
            FirstName = firstName;
            Birthday = birthday;
        }


        public string FamilyName
        {
            get => familyName;
            set
            {
                value = Format(value);
                ValidateName(value, "Incorrect data for FamilyName");
                familyName = value;
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                value = Format(value);
                ValidateName(value, "Incorrect data for FirstName");
                firstName = value;
            }
        }

        public DateTime Birthday
        {
            get => birthday;
            set
            {
                ValidateBirthday(value);
                birthday = value;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({Birthday:yyyy-MM-dd})";
        }

        private void ValidateName(string name, string error)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(error);
            }

            if (char.IsLower(name[0]))
            {
                throw new ArgumentException(error);
            }

            if (name.Length < 2)
            {
                throw new ArgumentException(error);
            }

            int specialMarksCounter = 0;

            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    specialMarksCounter++;
                    if (c != '-')
                    {
                        throw new ArgumentException(error);
                    }
                }
            }

            if (specialMarksCounter > 1)
            {
                throw new ArgumentException(error);
            }
        }

        private void ValidateBirthday(DateTime date)
        {
            if (date > DateTime.Now)
            {
                throw new ArgumentException("Incorrect data for Birthday");
            }
        }

        private string Format(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                name = name.Replace(" ", "");
            }
            return name;
        }
    }
}
