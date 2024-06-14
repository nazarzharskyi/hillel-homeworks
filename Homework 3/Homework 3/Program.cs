namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            int age = -1;
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
                if (age != null && age>=0 && age<=100)
                {
                    user1 = new User(age);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You`ve entered it incorrect, try again");
                }
            }


            string firstName = "", lastName = "";
            firstName = UserInput("name");
            user1.FirstName = firstName;
            lastName = UserInput("surname");
            user1.LastName = lastName;


            while (true)
            {
                Console.Write("1. Male \n2. Female \n3. Unknown \nChoose your gender: ");
                string genderInput = Console.ReadLine();

                if (GenderValidator.TryParseGender(genderInput, out Gender gender))
                {
                    user1.Gender = gender;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You've entered something incorrect, try again");
                }
            }
            Console.WriteLine(user1.ToString());
        }
        static private string UserInput(string whatType) 
        {
            string input = "";
            bool isDigit = false;
            while (true)
            {
                isDigit = false;
                Console.Write($"Enter your {whatType}: ");
                try
                {
                    input = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                foreach (char s in input)
                {
                    if (Char.IsDigit(s))
                    {
                        isDigit = true;
                        break;
                    }
                }
                bool isNotEmpty = string.IsNullOrEmpty(input);
                if (!isNotEmpty && !isDigit)
                {
                    Console.Clear();
                    return input;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You`ve entered it incorrect, try again");
                }
            }
        }
    }
}