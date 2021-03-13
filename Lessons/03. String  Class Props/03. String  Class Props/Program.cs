using System;

namespace _03._String__Class_Props
{
    class Program
    {
        static void FindLetter(string str, char letter)
        {
            int index = str.IndexOf(letter);
            while(index != -1)
            {
                Console.WriteLine($"Letter found in index {index}");
                index = str.IndexOf(letter, index + 1);
            }
        }

        static void FindOneOf(string str, string set)
        {
            int index = str.IndexOfAny(set.ToCharArray());
            while (index != -1)
            {
                Console.WriteLine($"Symbol  {str[index]} found in index {index}");
                index = str.IndexOfAny(set.ToCharArray(), index + 1);
            }
        }

        static void Main(string[] args)
        {

            // Example 1 
            string str = "Hello World!"; // Immutable
            string str2 = @"To be, or not to be, that is the question:
                            Whether 'tis nobler in the mind to suffer
                            The slings and arrows of outrageous fortune,
                            Or to take arms against a sea of troubles
                            And by opposing end them."; // Immutable
                                                        //Console.WriteLine(str);
                                                        //Console.WriteLine(str.Replace("o", "@"));
                                                        //Console.WriteLine(str.ToLower());
                                                        //Console.WriteLine(str.ToUpper());
                                                        //Console.WriteLine(str);

            //char[] symbols = str.ToCharArray();
            //Console.WriteLine(str.IndexOf("W"));


            // Example 2

            //FindLetter(str2, 'o');
            //FindOneOf(str2, ",:.'-");
            //Console.WriteLine($"Remove =>  str2.Remove(0, 5): {str2.Remove(0, 5)} ");
            //Console.WriteLine($"Incert => : {str2.Insert(2, " TEST ")} ");

            Console.WriteLine("====================SPLIT===================");
            string[] words = str2.Split(" :,\'.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


            //Array.Sort(words, (x, y) => String.CompareOrdinal(x, y));
            foreach (var item in words)
            {
                Console.WriteLine($"{item}");
            }

            //https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-5.0
        }
    }
}
