using System;

namespace Beispiel
{
    class Program
    {
        static void Main(string[] args)
        {
                     
           Mard x = new Mard();
           
           Console.WriteLine("You are talkative true or false?");           
                    
           x.Shataxosutyun = Convert.ToBoolean(Console.ReadLine());
           Console.WriteLine(x.Shataxosutyun);
        }

    }
    class Mard 

    {
        public bool Shataxosutyun

        {
            set
            {
                if (value == true)
                { 
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Beep();
                    }
                }
                else
                {
                    for (int i = 0; i < 2; i++)
                    Console.Beep();
                                   }
                 Console.WriteLine("You speak little");
            }
            get
            {
                return Shataxosutyun; 
            }

        }

    }
}
