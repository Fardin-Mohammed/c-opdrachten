﻿
namespace IntroProject
{
    internal class Program
    {
        string myDisplayName;
        int myAge;
        static void Main(string[] args)
        {
            Program myProgram= new Program();
            myProgram.Run();
             
        }

        internal Program()
        {
                //ken waardes toe aan de variabelen (assignement (=))
                myDisplayName = "Fardin";
                myAge = 15;//hier stellen we de leeftijd in
        }

        private void Run()
        {
            Console.WriteLine("hello!, let me introduce myself");
            Console.WriteLine("i'm "+myDisplayName);

            //vraag de waarde van myAge waar de vraagtekens staan
            string myAgeSentance = "i'm " + 15 +" years old";
            Console.WriteLine(myAge);//gebruik hier myAgeSentance 

        }
    }
}
