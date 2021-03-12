using System;

namespace AsciiArtExerc_cio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Olá professor!\n(Aperte uma tecla)");
            Console.WriteLine();
            Console.ReadKey();
            //Aperte um botão.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" ||  || 
 \\()//
//(__)\\
||    ||");
            Console.WriteLine();
            Console.ResetColor();

        }
    }
}
