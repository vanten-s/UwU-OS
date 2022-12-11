using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Finder;
using USF;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;


namespace SystemCommands
{

    class systemCommands
    {

        public void y(string text = "")
        {
            if (string.IsNullOrEmpty(text))
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("y");
                }
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(text);
                }
            }
        }

        public void clear()
        {
            Console.Clear();
        }

        public float math(string input)
        {   
            float product = 0;
            string Number1 = "";
            string Number2 = "";
            char CalcMethod = 'e';
            if (string.IsNullOrEmpty(input)) 
            {
                Console.WriteLine("Nothing to calculate");

            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!new[] { '*', '/', '+', '-' }.Contains(input[i]) && CalcMethod == 'e')
                    {
                        Number1 += input[i];
                        continue;
                    }
                    else if(!new[] { '*', '/', '+', '-' }.Contains(input[i]) && CalcMethod != 'e')
                    {
                        Number2 += input[i];
                    }

                    else
                    {
                        CalcMethod = input[i];
                        continue;
                    }

                    
                }

                switch (CalcMethod)
                {
                    case '*':
                        product = float.Parse(Number1, CultureInfo.InvariantCulture) * float.Parse(Number2, CultureInfo.InvariantCulture);
                        Console.WriteLine(product);

                        break;

                    case '/':
                        product = float.Parse(Number1, CultureInfo.InvariantCulture) / float.Parse(Number2, CultureInfo.InvariantCulture);
                        Console.WriteLine(product);

                        break;

                    case '+':
                        product = float.Parse(Number1, CultureInfo.InvariantCulture) + float.Parse(Number2, CultureInfo.InvariantCulture);
                        Console.WriteLine(product);

                        break;
                    case '-':
                        product = float.Parse(Number1, CultureInfo.InvariantCulture) - float.Parse(Number2, CultureInfo.InvariantCulture);
                        Console.WriteLine(product);

                        break;
                }
               
            }
            
            return product;

            }

        public void echo(string message)
        {
            Console.WriteLine(message);
        }

        public void poweroff()
        {
            Sys.Power.Shutdown();
        }

        }
    }
