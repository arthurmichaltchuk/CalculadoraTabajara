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

            bool validarOperacao = false;
            string operacao = "";

            while (validarOperacao == false) {
                Console.WriteLine("Digite a operação desejada: \n 1- somar\n 2- subtrair\n 3-dividir \n 4-multiplicar");
                operacao = Console.ReadLine();

                validarOperacao = ValidarOperacao(operacao);
            }

            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            

            #endregion

            #region operacoes
            int resultado = 0;
            string operacaoFeita = "";
            switch(operacao){
                case "1": resultado = primeiroNumero + segundoNumero; break;
                case "2": resultado = primeiroNumero - segundoNumero; break;
                case "3": resultado = primeiroNumero / segundoNumero; break;
                case "4": resultado = primeiroNumero * segundoNumero; break;

                default:
                    break;
                
            }

            switch (operacao)
            {
                case "1": operacaoFeita = "Soma"; break;
                case "2": operacaoFeita = "Subtração"; break;
                case "3": operacaoFeita = "Divisão"; break;
                case "4": operacaoFeita = "Multiplicação"; break;
            }

            #endregion

            #region mostrarResultado

            Console.WriteLine(resultado);

            #endregion
        }

        public static bool ValidarOperacao(string operacao)
        {
            if (operacao != "1" || operacao != "2" || operacao != "3" || operacao != "4")
                return false;
            return true;
        }
    }
}
