using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encode_decode4
{
    class Program
    {
        static string encode(string s) {
            string res="";
            string str1 = "aeiouy" ;
            string str2 = "AEIOUY" ;
            string str3 = "BCDFGHJKLMNPQRSTVWXZ";
            string str4 = "bcdfghjklmnpqrstvwxz"; 
            foreach (char i in s) {
                if (str1.Contains(i)) {
                    res += str1[(str1.IndexOf(i) + 3) % str1.Length];
                    continue;
                }
                if (str2.Contains(i))
                {
                    res += str2[(str2.IndexOf(i) + 3) % str2.Length];
                    continue;
                }
                if (str3.Contains(i))
                {
                    res += str3[(str3.IndexOf(i) + 10) % str3.Length];
                    continue;
                }
                if (str4.Contains(i))
                {
                    res += str4[(str4.IndexOf(i) + 10) % str4.Length];
                    continue;
                }
                res += i;
            }
            return res;
        }
        static string decode(string s) {
            string res = "";
            string str1 = "aeiouya";
            string str2 = "AEIOUYA";
            string str3 = "BCDFGHJKLMNPQRSTVWXZZ";
            string str4 = "bcdfghjklmnpqrstvwxzz";
            foreach (char i in s)
            {
                if (str1.Contains(i))
                {
                    res += str1[(str1.Length-1+(str1.IndexOf(i) - 3)) % (str1.Length-1)];
                    continue;
                }
                if (str2.Contains(i))
                {
                    res += str2[(str2.Length - 1 + (str2.IndexOf(i) - 3)) % (str2.Length - 1)];
                    continue;
                }
                if (str3.Contains(i))
                {
                    res += str3[(str3.Length - 1 + (str3.IndexOf(i) - 10)) % (str3.Length - 1)];
                    continue;
                }
                if (str4.Contains(i))
                {
                    res += str4[(str3.Length - 1 + (str4.IndexOf(i) - 10)) % (str4.Length - 1)];
                    continue;
                }
                res += i;
            }
            return res;
        }
        static void run() {
            while (true)
            {
                Console.WriteLine("Encode 1\nDecode 2\nExit 3");
                int n = int.Parse(Console.ReadLine());
                if (n == 3)
                    break;
                switch (n) {
                    case 1:
                        Console.WriteLine("\nEnter text to encode");
                        Console.WriteLine("\n"+encode(Console.ReadLine())+"\n");
                        break;
                    case 2:
                        Console.WriteLine("\nEnter text to decode");
                        Console.WriteLine("\n"+decode(Console.ReadLine())+"\n");
                        break;
                }
            }
            Console.WriteLine("Good bye");
        }
        static void Main(string[] args)
        {
            run();
            Console.ReadLine();
        }
    }
}
