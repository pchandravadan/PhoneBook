using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int phoneBookLength = 0;
            //int result = 1;
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string query;


            var x = Console.ReadLine();
            int.TryParse(x, out int count);

            while (count > 0)
            {
                string record= Console.ReadLine();
                string[] values = new string[2];
                values= record.Split(' ');

                PhoneBook.Add(values[0], values[1]);

                count--;
            }

            List<string> queries = new List<string>();
            do
            {
                query = Console.ReadLine();

                if (!string.IsNullOrEmpty(query))
                {
                    queries.Add(query);
                }
            }
            while (!string.IsNullOrEmpty(query));

            foreach (var key in queries)
            {
                if (PhoneBook.ContainsKey(key))
                {
                    PhoneBook.TryGetValue(key, out string val);
                    Console.WriteLine(key + "=" + val);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

            //while (result != 0)
            //{
            //    result = Console.Read();
            //    Console.Write(result);
            //    Int64.TryParse(result, out phoneBookLength);
            //    Console.Write(phoneBookLength);
            //}

            //string m1 = "\nType a string of text then press Enter. " +
            //    "Type '+' anywhere in the text to quit:\n";
            //string m2 = "Character '{0}' is hexadecimal 0x{1:x4}.";
            //string m3 = "Character     is hexadecimal 0x{0:x4}.";
            //char ch;
            //int x;
            ////
            //Console.WriteLine(m1);
            //do
            //{
            //    x = Console.Read();
            //    try
            //    {
            //        ch = Convert.ToChar(x);
            //        if (Char.IsWhiteSpace(ch))
            //        {
            //            Console.WriteLine(m3, x);
            //            if (ch == 0x0a)
            //                Console.WriteLine(m1);
            //        }
            //        else
            //        {
            //            Console.WriteLine(m2, ch, x);
            //        }
            //    }
            //    catch (OverflowException e)
            //    {
            //        Console.WriteLine("{0} Value read = {1}.", e.Message, x);
            //        ch = Char.MinValue;
            //        Console.WriteLine(m1);
            //    }
            //} while (ch != '+');
        }
    }
}
