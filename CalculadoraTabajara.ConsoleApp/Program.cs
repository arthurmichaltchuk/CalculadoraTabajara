﻿using System;
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

            Console.WriteLine("Digite a operação desejada: \n 1- somar\n 2- subtrair\n 3-dividir \n 4-multiplicar");
            string operacao = Console.ReadLine(); 

            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            

            #endregion

            #region operacoes
            int resultado = 0;
            switch(operacao){
                case "1": resultado = primeiroNumero + segundoNumero; break;
                case "2": resultado = primeiroNumero - segundoNumero; break;
                case "3": resultado = primeiroNumero / segundoNumero; break;
                case "4": resultado = primeiroNumero * segundoNumero; break;

                default:
                    break;
                
            }

            #endregion

            #region mostrarResultado

            Console.WriteLine(resultado);

            #endregion
        }
    }
}
