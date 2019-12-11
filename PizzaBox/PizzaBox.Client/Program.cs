using System;
using PizzaBox.Domain;
using System.IO;

namespace PizzaBox
{
    class Program
    {
        static void Main()
        {
           Console.WriteLine("Welcome to Simar Pizza Pallor!");
           pratice();
           TerminalController aStart = new TerminalController();
           
           aStart.StartingBlurb();
        }
        public static void pratice(){
            string path = Path.Combine(Environment.CurrentDirectory, @"PizzaBox.Storing/Test.txt");
          Console.WriteLine(path);
        }
       
        }
    }

