using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public sealed class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; init; }
        public Gender Gender {get; set;}
        public User()
        {
        }
        public User(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            if (Age <= 10) 
            {
                Console.Clear();
                return "Hello, I am a baby!";
            }
            else
            {
                Console.Clear();
               return $"First name: {FirstName}\nLast name: {LastName} \nAge: {Age} y.o.\nGender: {Gender}";
            }
        }
    }
}
