using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Input

            bool validarOperacao = true;
            string operacao = "";

            while (validarOperacao)
            {

                Console.WriteLine("Digite a operação desejada: \n 1- somar\n 2- subtrair\n 3-dividir \n 4-multiplicar");
                operacao = Console.ReadLine();

                validarOperacao = ValidarOperacao(operacao);
                MensagemDeErro(validarOperacao);

            }

            int primeiroNumero = 0;
            int segundoNumero = 0;
            bool validarDivisao = true;
            while (validarDivisao){ 
                Console.WriteLine("Digite o primeiro número: ");
                primeiroNumero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                segundoNumero = Convert.ToInt32(Console.ReadLine());

                validarDivisao = ValidarDivisao(primeiroNumero, segundoNumero);
            }
            #endregion

            #region operacoes
            int resultado = 0;

            switch (operacao)
            {
                case "1": resultado = primeiroNumero + segundoNumero; break;
                case "2": resultado = primeiroNumero - segundoNumero; break;
                case "3": resultado = primeiroNumero / segundoNumero; break;
                case "4": resultado = primeiroNumero * segundoNumero; break;
                default: break;
            }

            string operacaoFeita = pegarTipoOperacao(operacao);

            #endregion

            #region mostrarResultado

            Console.WriteLine("O resultado da " + operacaoFeita + " foi " + resultado + "...");
            Console.ReadKey();

            #endregion
        }
        private static void MensagemDeErro(bool validar)
        {
            if (validar)
            {
                Console.WriteLine("Digite uma opção válida!");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static bool ValidarDivisao(int primeiroNumero, int segundoNumero)
        {
            if (primeiroNumero == 0 || segundoNumero == 0)
                return false;
            return true;
        }
        private static string pegarTipoOperacao(string operacao)
        {
            string operacaoFeita = "";
            switch (operacao)
            {
                case "1": operacaoFeita = "Soma"; break;
                case "2": operacaoFeita = "Subtração"; break;
                case "3": operacaoFeita = "Divisão"; break;
                case "4": operacaoFeita = "Multiplicação"; break;
            }
            return operacaoFeita;
        }

        public static bool ValidarOperacao(string operacao)
        {
            if (operacao == "1" || operacao == "2" || operacao == "3" || operacao == "4")
                return false;
            return true;
        }
    }
}
