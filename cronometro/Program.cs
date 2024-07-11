using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            menu();
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Bye");
                    break;
                case 1:

                    cronometro();
                    break;
                case 2:


                    break;
               
            }




            Console.Read();
        }

        static void menu()
        {
            Console.WriteLine("Olá seja bem vindo ao conômetro! O que você deseja?\n");
            Console.WriteLine("1- Iniciar cronômetro\n2- Timer");
            Console.WriteLine("0- Sair");

        }

        
        static void cronometro()
        {
            

            int hora = 0, minuto = 0, segundo = 0, i = 0 ;
            while(i == 0)//for (int i = 0; i == 1; segundo++)
            {
                segundo++;
                if (segundo >= 60)
                {
                    minuto++;
                    segundo = 0;
                }
                if (minuto >= 60)
                {
                    hora++;
                    minuto = 0;
                }
                Console.Clear();
                Console.WriteLine($"{hora}:{minuto}:{segundo}");
                Thread.Sleep(1000);
                
            }
      
        }
    }
}
