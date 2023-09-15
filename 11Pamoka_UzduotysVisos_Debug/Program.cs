using System.Text;

namespace _11Pamoka_UzduotysVisos_Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uzd62();
        }


        private static void uzd1()
        {

            int a = 10;
            int b = 5;
            int c = 8;

            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
                max = c; //klaida: buvo b

            Console.WriteLine("The maximum value is: " + max);
        }


        private static void uzd2()
        {
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;   //nebuvo tarpo
            Console.WriteLine("Full Name: " + fullName);
        }




        private static void uzd3()
        {
            int counter = 0;
            while (counter <= 10)
            {
                Console.WriteLine("Count:" + counter);
                counter++;  // buvo minus
            }
        }



        private static void uzd4()
        {
            int i = 1;  //i = 5;
            while (i <= 5)  //(i > 0)
            {
                Console.WriteLine(i);
                i++;

            }
        }



        private static void uzd5()
        {
            string name1 = "John";
            string name2 = "john";

            if (name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase)) //
            {
                Console.WriteLine("Names are the same.");
            }
            else
            {
                Console.WriteLine("Names are different.");
            }
        }



        private static void uzd6()
        {
            Console.WriteLine("Irasyti sakini: ");
            string name = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                builder.Append(name[i]);
            }
            Console.WriteLine(builder.ToString());
        }



        private static void uzd62()
        {
            Console.WriteLine("Irasyti sakini: ");
            string word = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                bool isLetterDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (word[i] == word[j])
                    {
                        isLetterDuplicate = true;
                    }
                }
                if (!isLetterDuplicate)
                {
                    result.Append(word[i]);
                }
            }
            Console.WriteLine(result.ToString());
        }

    }
}