using System;

namespace MediaDoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algoritimo 3 - Leia as duas notas de um aluno, faça a media aritimetica
            // e escreva se o aluno tirou acima de 7, aprovado, e caso contrário, escreva
            // reprovado

            double n1, n2, media;

            Console.WriteLine("Informe a primeira nota do aluno");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("Media: {0}", media);

            if(media > 6){
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
