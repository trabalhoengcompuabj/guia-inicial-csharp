class variaveis_e_tipos {
    static void Main() {

        //Para compreender melhor como funcionam as variaveis e os seus tipos em C# vamos exemplificar cada uma.



        //Numeros Inteiros:
        //Servem para guardar numeros sem casa decimais.
        //O int eh o padrao absoluto para numeros inteiros e ocupa 32 bits.
        int ano_de_nascimento = 2002;

        //O long eh usado para numeros muito grandes, maiores que 2 bilhoes. Ele ocupa 64 bits e vem acompanhado de um L ao fim do numero
        //para ajudar o c# a identificar que eh um long.
        long populacao_mundial = 8301598750L;



        //Numeros Com Virgula:
        //Servem para guardar numeros fracionados.
        //O double eh o padrao para calculos matematicos comuns.
        double altura = 1.75;

        //O float ocupa menos memoria, mas tem menos precisao. Eh muito utilizado em jogos (Unity) e exige ser acompanhado da letra f no final.
        float velocidade = 80.5f;

        //O decimal evita erros de arrendondamento que o double pode causar. Eh obrigatorio quando lidar com dinheiro e exige a letra m no final.
        decimal saldo_bancario = 1620.50m;



        //Texto e Caracteres:
        //Servem para guardar letras ou palavras.
        //O char guarda apenas um unico caractere e sempre usa aspas simples ''.
        char letra = 'm';

        //O string guarda 2 caracteres ou mais, sendo usado para textos complexos. Sempre usa aspas duplas "".
        string frase = "Introducao a engenharia da computacao";



        //Booleano (logico):
        //Eh a caixa mais simples de todas, so aceita true (verdadeiro) ou false (falso).
        //Possui apenas bool.
        bool luz_ligada = true;


        //A regra o var:
        //Em C# moderno, se o valor da variável já deixa óbvio o que ela é, você pode usar a palavra var e deixar o compilador descobrir o tipo sozinho.
        var nome = "Matheus"; //O C# entende na mesma hora que isso eh uma string.



        Console.WriteLine($"Ano de Nascimento: {ano_de_nascimento}\n");
        Console.WriteLine($"Populacao Mundial: {populacao_mundial}\n");
        Console.WriteLine($"Altura: {altura}\n");
        Console.WriteLine($"Velocidade: {velocidade}\n");
        Console.WriteLine($"Saldo Bancario: R${saldo_bancario}\n");
        Console.WriteLine($"Letra: {letra}\n");
        Console.WriteLine($"Frase: {frase}\n");
        Console.WriteLine($"Luz Ligada: {luz_ligada}\n");
        Console.WriteLine($"Nome: {nome}\n");
    }
}