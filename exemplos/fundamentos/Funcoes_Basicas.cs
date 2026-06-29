using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // O void executa o print direto de dentro dele
            FuncoesBasicas.ShowMessage();
            
            // Printando o retorno de cada tipo de função com a indicação ao lado
            Console.WriteLine(FuncoesBasicas.GetAge() + " -> isso foi int");
            Console.WriteLine(FuncoesBasicas.GetName() + " -> isso foi string");
            Console.WriteLine(FuncoesBasicas.IsStudying() + " -> isso foi bool");
            Console.WriteLine(FuncoesBasicas.GetHeight() + " -> isso foi double");
            Console.WriteLine(FuncoesBasicas.GetPrice() + " -> isso foi float");
            Console.WriteLine(FuncoesBasicas.GetInitial() + " -> isso foi char");
            Console.WriteLine(FuncoesBasicas.GetLargeId() + " -> isso foi long");

            // Chamando a função não-static via objeto (instância)
            FuncoesBasicas objeto = new FuncoesBasicas();
            Console.WriteLine(objeto.GetCity() + " -> isso foi string (não-static)");
        }
    }

    class FuncoesBasicas
    {
        // Executa uma ação e não retorna nenhum dado.
        public static void ShowMessage()
        {
            Console.WriteLine("Função executada -> isso foi void");
        }

        // Retorna um número inteiro (int).
        public static int GetAge()
        {
            return 18;
        }

        // Retorna um texto (string).
        public static string GetName()
        {
            return "Caio";
        }

        // Retorna verdadeiro ou falso (bool).
        public static bool IsStudying()
        {
            return true;
        }

        // Retorna um número decimal de dupla precisão (double).
        public static double GetHeight()
        {
            return 1.75;
        }

        // Retorna um número decimal de precisão simples (float).
        public static float GetPrice()
        {
            return 5.99f;
        }

        // Retorna apenas um único caractere (char).
        public static char GetInitial()
        {
            return 'C';
        }

        // Retorna um número inteiro muito grande (long).
        public static long GetLargeId()
        {
            return 918273645546372L;
        }

        // Exemplo não-static: Funciona igual aos de cima, mas precisa instanciar com 'new'.
        public string GetCity()
        {
            return "Belo Jardim";
        }
    }
}