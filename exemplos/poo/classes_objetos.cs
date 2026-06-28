/*
Imagine a classe como um "molde", ela define as características (atributos)
e os comportamentos (métodos) que os objetos criados a partir dela terão, esse
é o principal paradigma da linguagem em C# chamado de POO ("Programação orientada a objeto").
*/



// Classe que representa uma pessoa
class Pessoa
{
    // Atributos da classe pessoa
    public string Nome;
    public int Idade;

    // Método
    public void Apresentar()
    {
        Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos.");
    }
}



/*
Uma vez definida a classe 'Pessoa', não precisamos reescrever 
essa estrutura toda vez que quisermos representar alguém no sistema.
Basta criar novos objetos a partir desse mesmo molde, reaproveitando 
o código de forma simples e eficiente.
*/



class Pessoas {
    static void Main()
    {
        // Criando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa();

        // Atribuindo valores aos atributos da pessoa 1
        pessoa1.Nome = "Matheus";
        pessoa1.Idade = 19;

        // Chamando o método
        pessoa1.Apresentar();



        // Criando novamente um objeto da classe Pessoa
        Pessoa pessoa2 = new Pessoa();

        // Atribuindo valores aos atributos da pessoa 2
        pessoa2.Nome = "Vini Jr.";
        pessoa2.Idade = 25;

        // Chamando o método
        pessoa2.Apresentar();
    }
}



/*
Criamos dois objetos distintos ('pessoa1' e 'pessoa2') baseados na mesma 
classe "Pessoa". Não foi necessário reescrever a estrutura de dados nem o método 
"Apresentar()"; apenas os reutilizamos, mudando os valores de cada objeto.
 
Ao executar o código acima, a saída no terminal será: 
Olá! Meu nome é Matheus e tenho 19 anos.
Olá! Meu nome é Vini Jr. e tenho 25 anos.
*/