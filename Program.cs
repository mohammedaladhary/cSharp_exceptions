namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] myNumbers = { 1, 2, 3 };
            //Console.WriteLine(myNumbers[10]); // error!
            //----------T1-------------
            //Console.WriteLine(divide(4,2));
            //Console.WriteLine(divide(5,2));
            //Console.WriteLine(divide(6,2));
            //loop();
            //----------T2-------------
            //ageUser();
            //----------T3-------------
            filePath();
        }
        //-------------------------Task1----------------------------
        private static float divide(int a, int b)
        {
            return a / b;
        }
        private static void loop()
        {
            int[] myNumbers = { 1, 2, 3 };
            //for (int i = 0; i < myNumbers.Length; i++)
            //{
            //    Console.WriteLine(myNumbers[i]);
            //}
            try
            {
                Console.WriteLine(myNumbers[0] / myNumbers[2]);
                Console.WriteLine(myNumbers[10] / myNumbers[1]);
                Console.WriteLine(myNumbers[0] / myNumbers[3]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ERROR: Some Error Occurred");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR: Cannot Divide by Zero");
            }
            Console.WriteLine(myNumbers[10] / myNumbers[1]); //unhelded exception cause crashes.
            Console.WriteLine("Program Completed");
        }
        //-----------------------Task2---------------------------
        private static void ageUser()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0)
                {
                    throw new ArgumentException("ERROR: Age cannot be negative.");
                }
                else
                {
                    Console.WriteLine("Age : " + age);

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, write a valid age number");
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
        }
        //---------------------Task3----------------
        private static void filePath()
        {
            try
            {
                Console.WriteLine("enter file path: ");
                string path = Console.ReadLine();
                FileStream fs = File.Open(path, FileMode.Open);

                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        // printing the file contents
                        Console.WriteLine(s);
                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}