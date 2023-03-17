using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_CriandoOutrasVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\n Exercício - Criando Variáveis utilizando o tipo int \r\n");

            Console.WriteLine("================================================================= \r\n");

            Console.WriteLine("Olá! \r\n");

            int idade;
            idade = 43;
            Console.WriteLine("Exemplo da criação de uma variável de idade inicializada na linha seguinte é:");
            Console.WriteLine("-> int idade");
            Console.WriteLine("-> idade = 43");
            Console.WriteLine("A idade é: " + idade + "\r\n \r\n");
            

            int idade2 = 23;
            Console.WriteLine("Exemplo da criação de uma variável de idade inicializada na mesma linha é:");
            Console.WriteLine("-> int idade2 = 23");
            Console.WriteLine("A idade é: " + idade + "\r\n \r\n");

            Console.WriteLine("--------------------------------------------------------------- \r\n \r\n");

            Console.WriteLine("Execução concluída!");
            Console.WriteLine("Pressione o enter para fechar.");
            Console.ReadLine();
        }
    }
}
