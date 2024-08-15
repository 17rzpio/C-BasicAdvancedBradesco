using System;

namespace ConsoleApp4OperadorRelacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            Boolean resposta;
            Console.WriteLine("Hello World!");

            Console.WriteLine("\na é" + a+" e b é"+ b);
            resposta = (a == b);
            Console.WriteLine("\nIGUAL: a==b"+resposta);
            resposta = (a != b);
            Console.WriteLine("\nDIFERENÇA: a!=b"+resposta);
            resposta = (a > b);
            Console.WriteLine("\nMAIOR QUE: a>b"+resposta);
            resposta = (a < b);
            Console.WriteLine("\nMENOR QUE: a<b"+resposta);
            a = 5;
                Console.WriteLine("\na é" + a);
            resposta = (a >= b);
            Console.WriteLine("\nMAIOR OU IGUAL: a>=b"+resposta);
            b = 3;

            Console.WriteLine("\na é" + a + " e b é" + b);
            a = 3;

            Console.WriteLine("\na é" + a + " e b é" + b);
            resposta = (a <= b);
            Console.WriteLine("\nMENOR IGUAL: a<=b"+resposta);

            Boolean a2 = true, b2 = false;
            Console.WriteLine("\na2 é" + a2 + " e b2 é" + b2);
            resposta = (a2 && b2);
            Console.WriteLine("\nAND:  a2 && b2"+resposta);
            resposta = (a2 || b2);
            Console.WriteLine("\nOR: a2 || b2"+resposta);
            b2 = !b2;
            Console.WriteLine("\nNOT: !b2" + b2);
            



        }
    }
}
