class Entrada_e_Saida {
    static void Main(){

    /*Para compreender da melhor forma entrada e saída vamos
    fazer uma ficha perguntando informações simples*/

    Console.WriteLine("Bem vindo ao programa de ficha de cadastro do exército\n");

    //Exemplo de entrada de string:
    Console.WriteLine("Insira seu nome:"); 
    String nomeUsuario = Console.ReadLine();

    /*
    Console.WriteLine("Insira seu nome:"); 
    -> Nesta linha está sendo dito: Console escreva uma linha com esse texto

    String nomeUsuario = Console.ReadLine(); 
    -> Já nessa linha está sendo dito: Para a variável do tipo string coloque dentro dela o que o console ler
    
    Observação Nesta trecho do código foi utilizado o "Console.WriteLine" para inserir uma linha de
    texto, entretanto, também existe "Console.Write" a única diferença entre os dois é que:

    Write = Escreve na mesma linha
    WriteLine = Escreve e pula linha

    Também foi utilizado "Console.ReadLine" que serve para o programa o programa
    coletar a informação digitada pelo usuário.
    */



    //Exemplo de entrada de um número inteiro
    Console.WriteLine("Insira sua idade:");
    String idadeUsuario = Console.ReadLine();
    int idade = int.Parse(idadeUsuario);

    /*~
    Nesta parte foi utilizado além do WriteLine e ReadLine o comando Parse,
    ele serve basicamente para converter caracteres em numero.

    Essa conversão é necessária porque em c# tudo que o computador coleta de informação
    é em formato de caracteres, então sempre que você coletar algo que é número lembre-se
    de usar o Parse!
    */



    //Exemplo de entrada de um número real
    Console.WriteLine("Insira sua altura:");
    string alturaUsuario = Console.ReadLine();
    double altura = double.Parse(alturaUsuario);

    /*
    Aqui foi utilizado o tipo de variável "double" além das outras coisas citadas acima,
    ela serve para que o computador armazene números reais
    */



    //Aqui apenas está sendo impresso as informações coletadas anteriormente
    Console.WriteLine("|-Ficha de cadastro final-|\n");
    Console.WriteLine($"Nome do usuário: {nomeUsuario}\n");
    Console.WriteLine($"Idade do usuário: {idade} anos\n");
    Console.WriteLine($"Altura do usuário: {alturaUsuario}m\n");

    //Aqui está um exemplo de uso do Parse, caso não utilizassemos não seria possível realizar tal soma
    Console.WriteLine($"O tempo de serviço militar obrigatório é de 8 anos, expectativa de idade de sair do exército: {idade + 8} anos\n");

    }
}