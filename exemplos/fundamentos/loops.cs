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
        // Executa o código enquanto a condição for atendida
        int regressivo = 10;

        while (regressivo >= 0) 
        {
            Console.WriteLine(regressivo);
            regressivo = regressivo - 1;
        }

        // Exemplo do loop do-while
        // Executa o código pelo menos uma vez antes de testar a condição
        int contagem = 0;

        do
        {
            Console.WriteLine(contagem);
            contagem = contagem + 1;
            
        } while (contagem <= 10);

        // Exemplo do loop foreach
        // Executa o código para cada elemento de um array ou lista
        string[] frutas = {"Uva", "Banana", "Laranja"};

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}