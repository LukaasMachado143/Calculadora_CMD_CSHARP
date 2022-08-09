using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTeste
{
    internal class Program
    {
        enum Menu { add = 1, subtract, share, multiply, potency, squareRoot, close };
        static void Main(string[] args)
        {
            bool closeProgram = false;
            Console.WriteLine("Seja bem vindo a CALCULADORA CMD com C#\n\n");
            while (!closeProgram)
            {
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("-> 1 - SOMAR\n-> 2 - SUBTRAIR\n-> 3 - DIVIDIR\n-> 4 - MULTIPLICAR\n-> 5 - POTÊNCIA\n-> 6 - RAIZ QUADRADA\n-> 7 - ENCERRAR\n");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case Menu.close:
                        Console.Clear();
                        Console.WriteLine("* Calculadora encerrada com sucesso *");
                        closeProgram = true;
                        Console.ReadLine();
                        break;
                    case Menu.add:
                        Console.Clear();
                        Console.WriteLine("* Opção ADICIONAR selecionada *\n");
                        addFunction();                        
                        break;
                    case Menu.subtract:
                        Console.Clear();
                        Console.WriteLine("* Opção SUBTRAIR selecionada *\n");
                        subtractFunction();
                        break;
                    case Menu.share:
                        Console.Clear();
                        Console.WriteLine("* Opção DIVIDIR selecionada *\n");
                        shareFunction();
                        break;
                    case Menu.multiply:
                        Console.Clear();
                        Console.WriteLine("* Opção MULTIPLICAR selecionada *\n");
                        multiplyFunction();
                        break;
                    case Menu.potency:
                        Console.Clear();
                        Console.WriteLine("* Opção POTENCIA selecionada *\n");
                        potencyFunction();
                        break;
                    case Menu.squareRoot:
                        Console.Clear();
                        Console.WriteLine("* Opção RAIZ QUADRADA selecionada *\n");
                        squareRootFunction();
                        break;
                }
            }
        }
        
        static void addFunction()
        {
            Console.WriteLine("Informe o primeiro número: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            float b = float.Parse(Console.ReadLine());
            float result = a + b;
            Console.WriteLine($"O resultado da soma é: {result}. \nPressione ENTER para seguir em frente.");
            Console.ReadLine();
            Console.Clear();
        }
        
        static void subtractFunction()
        {
            Console.WriteLine("Informe o primeiro número: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            float b = float.Parse(Console.ReadLine());
            float result = a - b;
            Console.WriteLine($"O resultado da subtração é: {result}. \nPressione ENTER para seguir em frente.");
            Console.ReadLine();
            Console.Clear();
        }

        static void shareFunction()
        {
            Console.WriteLine("Informe o primeiro número: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            float b = float.Parse(Console.ReadLine());
            float result = a/b;
            Console.WriteLine($"O resultado da divisão é: {result}. \nPressione ENTER para seguir em frente.");
            Console.ReadLine();
            Console.Clear();
        }

        static void multiplyFunction()
        {
            Console.WriteLine("Informe o primeiro número: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            float b = float.Parse(Console.ReadLine());
            float result = a*b;
            Console.WriteLine($"O resultado da multiplicação é: {result}. \nPressione ENTER para seguir em frente.");
            Console.ReadLine();
            Console.Clear();
        }
        static void potencyFunction()
        {
            Console.WriteLine("Informe a base da potência: ");
            float baseNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a potência: ");
            float potencyNumber = float.Parse(Console.ReadLine());
            float result = (float)Math.Pow(baseNumber,potencyNumber);
            Console.WriteLine($"O resultado de {baseNumber}^{potencyNumber} é: {result}. \nPressione ENTER para seguir em frente.");
            Console.ReadLine();
            Console.Clear();
        }

        static void squareRootFunction()
        {
            Console.WriteLine("Informe o número: ");
            float baseNumber = float.Parse(Console.ReadLine());
            float result = (float)Math.Sqrt(baseNumber);
            Console.WriteLine($"O resultado d raíz quadrada de {baseNumber} é: {result}. \nPressione ENTER para seguir em frente.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
