class Listas
{
    static void Main()
    {
        // Criação de uma lista
        List<string> jogos = new List<string>();



        // Adição de elementos a uma lista
        jogos.Add("Jogo quadrado");



        // Adiciona mais de um elemento a uma lista de uma única vez
        // Pode adicionar um array ou uma outra lista dentro da lista
        string[] adicional = {"Zelda", "Pokemon", "Terraria"};
        jogos.AddRange(adicional);



        // Modificar valores através do índice
        // OBS.: O primeiro elemento começa em índice zero
        jogos[0] = "Minecraft";                             // Índice 0 = Primeiro Elemento



        // Mostrar a quantidade de elementos na lista
        Console.WriteLine(jogos.Count);



        // Verificar se a lista contém um elemento específico 
        if (jogos.Contains("Minecraft"))
        {
            Console.WriteLine("Correspondência encontrada na lista");
        }



        // Reorganizar a lista
        // Ordem alfabética para textos
        // Ordem crescente para números
        jogos.Sort();



        // Reorganizar a lista na ordem inversa
        jogos.Reverse();



        // Mostrar posição do Índice de um elemento
        Console.WriteLine(jogos.IndexOf("Terraria"));



        // Remover elemento da lista
        jogos.Remove("Zelda");



        // Remover elemento da lista através do índice
        jogos.RemoveAt(1);                              // Índice 1 = Segundo Elemento



        // Transformar a lista em um array
        string[] jogosArray = jogos.ToArray();



        // Visualizar um elemento específico da lista
        Console.WriteLine(jogos[0]);                     // Índice 0 = Primeiro Elemento


        
        // Visualizar todos os elementos de uma lista
        foreach(string jogo in jogos)
        {
            Console.WriteLine(jogo);
        }



        // Limpar todos os elementos de uma lista
        // Eles são todos removidos
        jogos.Clear();
    }
}