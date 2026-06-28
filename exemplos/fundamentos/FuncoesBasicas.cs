using System;

namespace C_
{
    class FuncoesBasicas
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nao e possivel dividir por zero.");
            }

            return a / b;
        }

        public static bool EhPar(int numero)
        {
            return numero % 2 == 0;
        }

        public static int Fatorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("O numero precisa ser maior ou igual a zero.");
            }

            int resultado = 1;

            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        public static string CriarSaudacao(string nome)
        {
            return $"Ola, {nome}! Seja bem-vindo.";
        }
    }
}
