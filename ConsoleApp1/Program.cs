using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempt = 0;
            bool authenticated = false;

            while (true)
            {
                Console.Write("Enter Username: ");
                String username = Console.ReadLine();

                Console.Write("Enter Password: ");
                String password = Console.ReadLine();

                if (username == "root" & password == "letmein")
                {
                    Console.WriteLine("Username and password authenticated.. you may proceed!");
                    authenticated = true;
                    break;
                }
                else
                {
                    attempt++;
                }

                if (attempt == 3)
                {
                    Console.WriteLine("Too many incorrect login attempts!  Try again later!");
                    break;
                }



            }

            if (authenticated)
            {
                // Do something for authenticated users
                Console.WriteLine("Welcome to the site");
            }
            else
            {
                // Do something for people who are not authenticated (tried logging in too many times)
                Console.WriteLine("Go away");
            }

        }


        
    }
}
