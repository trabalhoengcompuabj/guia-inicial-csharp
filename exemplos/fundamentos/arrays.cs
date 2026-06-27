class Arrays
{
    static void Main()
    {
        // Criação de um array com tamanho pré-definido
        int[] numeros = new int[3];



        // Os valores dos elementos podem ser atribuidos depois da criação através do índice
        // OBS.: O primeiro elemento começa em índice zero 
        numeros[0] = 10;                                        // Índice 0 = Primeiro Elemento
        numeros[1] = 20;                                        // Índice 1 = Segundo Elemento
        numeros[2] = 30;                                        // Índice 2 = Terceiro Elemento



        // Criação de um array com elementos pré-definidos
        // O tamanho do array nesse caso é definido com base na quantidade de elementos inseridos na criação
        string[] dias = {"segunda", "terça", "quarta", "domingo", "sexta"};



        // Podemos modificar os valores de um elemento previamente definido através do índice
        dias[3] = "quinta";                                                                     // Índice 3 = Quarto Elemento



        // Mostrar a quantidade de elementos no array,
        Console.WriteLine(dias.Length);



        // Verificar se o array contém um elemento específico 
        if (dias.Contains("quarta"))
        {
            Console.WriteLine("Correspondência encontrada no array");
        }



        // Reorganizar o array
        // Ordem alfabética para textos
        // Ordem crescente para números
        Array.Sort(dias);



        // Reorganizar o array na ordem inversa
        Array.Reverse(dias);



        // Mostrar posição do Índice de um elemento
        Console.WriteLine(Array.IndexOf(dias, "terça"));



        // Transformar o array em uma lista
        List<string> diasLista = dias.ToList();


        // Visualizar um elemento específico do array
        Console.WriteLine(dias[4]);                     // Índice 4 = Quinto Elemento



        // Visualizar todos os elementos de um array
        foreach (string dia in dias)
        {
            Console.WriteLine(dia);
        }



        // Limpar todos os elementos de um array
        // Eles viram o elemento padrão do tipo correspondente:
        // Uma texto viraria um caractere vazio
        // Um número viraria zero 
        Array.Clear(dias);
    }
}