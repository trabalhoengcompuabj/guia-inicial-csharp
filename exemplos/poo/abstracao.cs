// Classe abstrata: funciona como um molde genérico para outras classes, dizendo o que elas são
// Obs.: Não podemos criar objetos diretamente com uma classe abstrata
abstract class Aparelho
{
    // Nela criamos comportamentos abstratos
    // Eles são utéis quando temos algum conceito abstrato
    public abstract void ligar();
    
    // Por exemplo, nesse caso, sabemos que os Aparelhos ligam, mas não sabemos exatamente oque acontece
    // dentro de cada aparelho diferente para que eles liguem. Não sabemos exatamente como é o processo
    // Por isso é um conceito abstrato
}



// Interface: funciona como uma capacidade genérica para classes, dizendo o que elas podem fazer
interface IWifi
{
    void conectarWifi();
}



// Interfaces não contêm lógicas internas, apenas declarações de comportamentos.
// e por convênção iniciamos o nome das interfaces com I
interface ITomada
{
    void conectarTomada();
}



// Classe concreta: pode herdar de uma classe abstrata e assinar interfaces
class Radio : Aparelho, ITomada
{
    // Método Override: É aqui que o conceito abstrato ganha sua lógica de funcionamento real com base no objeto
    public override void ligar()
    {
        Console.WriteLine("Rádio ligado");
    }

    // Os comportamentos de interfaces não utilizam o método override
    public void conectarTomada()
    {
        Console.WriteLine("Rádio conectado na tomada");
    }
}



// Classe concreta: podem assinar mais de uma interface, porém herdam somente de uma única classe abstrata
// Obs.: Não é preciso que a classe herde uma classe abstrata ou assine interfaces, podendo haver somente uma delas por vez
class Smartphone : Aparelho, IWifi, ITomada
{   
    public int bateria;

    public override void ligar()
    {
        Console.WriteLine("Celular ligado");
    }

    public void conectarWifi()
    {
        Console.WriteLine("Celular conectado ao wifi");
    }

    public void conectarTomada()
    {
        Console.WriteLine("Celular conectado na tomada");
    }
}

class Abstracao
{
    static void Main()
    {
        Smartphone celular = new Smartphone();
        Radio radio = new Radio();

        celular.ligar();

        celular.conectarWifi();

        celular.bateria = 50;

        celular.conectarTomada();

        radio.ligar();

        radio.conectarTomada();
    }
}