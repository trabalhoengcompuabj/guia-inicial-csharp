using System;

public class Loops
{
    public static void Main(string[] args)
    {
        // Exemplo do loop for
        // Executa o código por uma quantidade de vezes definida
        for (int numero = 1; numero <= 10; numero = numero + 1)
        {
            Console.WriteLine(numero);
        }

        // Exemplo do loop while
        // LEMBRAR DE POR EXPLICAÇÃO AQUI DEPOIS!!!!!!!
        int regressivo = 10;

        while (regressivo >= 0) 
        {
            Console.WriteLine(regressivo);
            regressivo = regressivo - 1;
        }
    }
}