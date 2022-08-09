using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTeste
{
    internal class Program
    {
        enum Menu { add = 1, subtract, share, multiply, potency, source, close };
        static void Main(string[] args)
        {
            bool closeProgram = false;
            Console.WriteLine("Seja bem vindo a CALCULADORA CMD com C#\n\n");
            while (!closeProgram)
            {
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("-> 1 - SOMAR\n-> 2 - SUBTRAIR\n-> 3 - DIVIDIR\n-> 4 - MULTIPLICAR\n-> 5 - POTÊNCIA\n-> 6 - RAIZ\n-> 7 - ENCERRAR\n");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case Menu.close:
                        Console.Clear();
                        Console.WriteLine("* Calculadora encerrada com sucesso *");
                        closeProgram = true;
                        break;
                    case Menu.add:
                        Console.WriteLine("* Opção ADICIONAR selecionada *");
                        Console.Clear();
                        break;
                    case Menu.subtract:
                        Console.WriteLine("* Opção SUBTRAIR selecionada *");
                        Console.Clear();
                        break;
                    case Menu.share:
                        Console.WriteLine("* Opção DIVIDIR selecionada *");
                        Console.Clear();
                        break;
                    case Menu.multiply:
                        Console.WriteLine("* Opção MULTIPLICAR selecionada *");
                        Console.Clear();
                        break;
                    case Menu.potency:
                        Console.WriteLine("* Opção POTENCIA selecionada *");
                        Console.Clear();
                        break;
                    case Menu.source:
                        Console.WriteLine("* Opção RAIZ selecionada *");
                        Console.Clear();
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}
