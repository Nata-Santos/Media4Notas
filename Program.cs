using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2, nota3, nota4, media;

            Console.Write("Digite o nome do Aluno: ");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n----Média do Aluno----");
            Console.ResetColor();

            Console.WriteLine("Digite suas notas abaixo. ");

            Console.Write("Nota 1 : ");
            nota1 = decimal.Parse(Console.ReadLine());

            if (nota1 <0 || nota1 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Environment.Exit(1);
            }


            Console.Write("Nota 2 : ");
            nota2 = decimal.Parse(Console.ReadLine());

            if (nota2 <0 || nota2 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Environment.Exit(1);
            }



            Console.Write("Nota 3 : ");
            nota3 = decimal.Parse(Console.ReadLine());

            if (nota3 <0 || nota3 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Environment.Exit(1);
            }


            Console.Write("Nota 4 : ");
            nota4 = decimal.Parse(Console.ReadLine());

            if (nota4 <0 || nota4 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Environment.Exit(1);
            }


            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"Voce ficou com média {media:N1}");

            if (media >= 6)
            {
                Console.WriteLine("Foi Aprovado.");

            }
            else
            {
                if (media <= 5)
                {
                    Console.WriteLine("Foi reprovado.");
                }
                else
                {
                    Console.WriteLine("Está em recuperação.");
                }
            }


        }
    }
}
