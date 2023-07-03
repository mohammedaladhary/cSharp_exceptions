namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] myNumbers = { 1, 2, 3 };
      //      Console.WriteLine(myNumbers[10]); // error!

            Console.WriteLine(divide(4,2));
            Console.WriteLine(divide(5,2));
            Console.WriteLine(divide(6,2));
            loop();
        }
        private static float divide (int a, int b)
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
            } catch (Exception ex)
            {
                Console.WriteLine("ERROR: Some Error Occurred");
            }
            Console.WriteLine(myNumbers[10] / myNumbers[1]); //unhelded exception cause crashes.
            Console.WriteLine("Program Completed");
        }
    }
}