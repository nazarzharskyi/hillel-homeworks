using System.Text;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool TrueFalse = false;
            User user1 = new User();
            int age = 0;
            while (true)
            {
                Console.Write("Enter your age: ");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (age >= 0)
                {
                    user1 = new User(age);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("You`ve entered it incorrect, try again");
                }
            }
            string firstName = "", lastName = "";
            while (true)
            {
                Console.Write("Enter your name: ");
                try
                {
                    firstName = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                foreach (char s in firstName)
                {
                    if (Char.IsDigit(s))
                    {
                        TrueFalse = true;
                        break;
                    }
                }
                if (!TrueFalse)
                {
                    user1.FirstName = firstName;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You`ve entered it incorrect, try again");
                }
            }
            while (true)
            {
                Console.Write("Enter your surname: ");
                try
                {
                    lastName = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                TrueFalse = false;
                foreach (char s in lastName)
                {
                    if (Char.IsDigit(s))
                    {
                        TrueFalse = true;
                        break;
                    }
                }
                if (!TrueFalse)
                {
                    user1.LastName = lastName;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You`ve entered it incorrect, try again");
                }

            }
            int gender = 0;
            bool TF = true;
            while (TF)
            {
                Console.Write("1. Male \n2. Female \n3. Unknown \nChoose your gender: ");
                try
                {
                    gender = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                switch(gender)
                {
                    case 1:
                        user1.Gender=Gender.Male;
                        TF = false;
                        Console.Clear();
                        break;
                    case 2:
                        user1.Gender = Gender.Female;
                        TF = false;
                        Console.Clear();
                        break;
                    case 3:
                        user1.Gender = Gender.Unknown;
                        TF = false;
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You`ve entered something incorrect, try again");
                        break;
                }
            }
            user1.ToString(); 
        }
    }
}
