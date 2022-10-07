using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass
{
    public enum Gender
    {
        MALE,
        FEMALE
    }

    public interface People
    {
        public abstract void addPeople(int age, Gender gender);
    }

    public class PeopleImplement : People
    {
        private int _age;
        private Gender _gender;
        public void addPeople(int age, Gender gender)
        {
            this._age = age;
            this._gender = gender;
        }

        public void ViewAddPeople()
        {
            Console.WriteLine("Your Age: {0}", _age);
            Console.WriteLine("Your Gender: {0}", _gender);
        }

    }
}
