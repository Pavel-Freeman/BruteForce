using System;

namespace Bruteforce
{
    class Program
    {
        //ввод алфавита для перебора
        static char[] Match = {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j' ,'k','l','m','n','o','p',
'q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','C','L','M','N','O','P',
'Q','R','S','T','U','V','X','Y','Z','!','?',' ','*','-','+','/','~'};

      

        static string FindPassword;
        static double Combi;
        static int Characters;
        
        static void Main(string[] args)
        {
            int i = 0;
            Console.Title = "Brute Force";
            Console.WriteLine("Enter your Password:");

            //инициализация пароля
            FindPassword = (Console.ReadLine());
            Characters = FindPassword.Length;
            Console.Clear();

            DateTime today = DateTime.Now;
            today.ToString("yyyy-MM-dd_HH:mm:ss");
            Console.WriteLine();
            Console.WriteLine("START:\t{0}", today);

            //организация цикла перебора
            if (FindPassword != "" && Char.IsDigit(FindPassword[i]) || FindPassword[i] >= 'a' && FindPassword[i] <= 'z' || FindPassword[i] >= 'A' && FindPassword[i] <= 'Z') { 
                for (int Count = 0; Count <= Characters; Count++)
                {
                    Recurse(Count, 0, String.Empty);
                }
            } else
            {
                Main(args);
            }
        }



        static void Recurse(int Lenght, int Position, string BaseString)
        
         {
            for (int Count = 0; Count < Match.Length; Count++)
            {
                Combi++;
                //string test = BaseString + Match[Count];
                //Console.WriteLine(test);
                if (Position < Lenght - 1)
                {
                    Recurse(Lenght, Position + 1, BaseString + Match[Count]);
                }
                if (BaseString + Match[Count] == FindPassword)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your password is: " + FindPassword);
                    Console.WriteLine("Your password is: " + Characters + " character(s) long");
                    Console.ForegroundColor = ConsoleColor.White;
                    DateTime today = DateTime.Now;
                    today.ToString("yyyy-MM-dd_HH:mm:ss");
                    Console.WriteLine();
                    Console.WriteLine("END:\t{0}\nCombi:\t{1}", today, Combi);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
    }
}