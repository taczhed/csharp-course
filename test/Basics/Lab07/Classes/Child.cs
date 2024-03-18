using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Basics.Lab07.Classes
{
    public class Child : Person
    {
        private Person mother_ref;
        private Person father_ref;

        public Child(string firstName, string familyName, int age, Person mother = null, Person father = null)
            : base(firstName, familyName, age)
        {
            mother_ref = mother;
            father_ref = father;

            ValidateChildAge(age);
        }

        public override string ToString()
        {
            string motherInfo = mother_ref != null ? $"mother: {mother_ref}" : "mother: No data";
            string fatherInfo = father_ref != null ? $"father: {father_ref}" : "father: No data";

            return $"{FirstName} {FamilyName} ({Age})\n{motherInfo}\n{fatherInfo}";
        }


        public new void modifyAge(int age)
        {
            ValidateChildAge(age);

            if (age < 0 || age > 15)
            {
                throw new ArgumentException("Child’s age must be between 0 and 15!");
            }

            base.modifyAge(age);
        }

        private void ValidateChildAge(int age)
        {
            if (age > 15)
            {
                throw new ArgumentException("Child’s age must be less than 15!");
            }
        }
    }
}