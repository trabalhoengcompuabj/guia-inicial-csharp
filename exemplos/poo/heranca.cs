// Classe Mãe: É a classe base que define a estrutura geral
// Contém os campos e propriedades comuns que serão compartilhados por outras classes
class Eletrodomestico
{
    public string marca;
    public bool ligado;
}



// Classe Filha: Ela herda a estrutura da classe mãe e adiciona características próprias
// Isso permite extender o código evitando repetições
class Fogao : Eletrodomestico
{
    public float temperatura;
}



// Classe Filha: Ela herda a estrutura da classe mãe e adiciona características próprias
// Isso permite extender o código evitando repetições
class Ventilador : Eletrodomestico
{
    public int velocidade;
}


class Heranca
{
    static void Main()
    {
        Fogao fogao = new Fogao();
        Ventilador ventilador = new Ventilador();


        // Definição dos valores da estrutura herdada da classe mãe
        fogao.marca = "Electrolux";
        ventilador.marca = "Arno";

        fogao.ligado = false;
        ventilador.ligado = true;



        // Definição dos valores da estrutura própria
        fogao.temperatura = 0;
        ventilador.velocidade = 3;


        Console.WriteLine($"O fogão da marca {fogao.marca} está {(fogao.ligado == true ? "ligado" : "desligado")}, com temperatura de {fogao.temperatura} graus.");
        Console.WriteLine($"O ventilador da marca {ventilador.marca} está {(ventilador.ligado == true ? "ligado" : "desligado")}, na velocidade {ventilador.velocidade}.");
    }
}