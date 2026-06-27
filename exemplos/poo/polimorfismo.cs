// Classe mãe: ela é a base para outras classes
class Forma
{
    // Método virtual: define um comportamento padrão que pode ser sobrescrito
    public virtual void lados()
    {
        Console.WriteLine("A forma tem X lados");
    }
}



// Classe filha: herda da classe mãe, modificando seus comportamentos
class Triangulo : Forma
{
    // Método override: sobreescreve um comportamento da classe mãe
    public override void lados()
    {
        Console.WriteLine("O triângulo tem 3 lados");
    }
}



// Classe filha: herda da classe mãe, modificando seus comportamentos
class Quadrado : Forma
{
    // Método override: sobreescreve um comportamento da classe mãe
    public override void lados()
    {
        Console.WriteLine("O quadrado tem 4 lados");
    }
}


class Polimorfismo
{
    static void Main()
    {   
        // Como as classes filhas herdam da mãe, elas mantêm o mesmo tipo base
        // Isso permite agrupar objetos diferentes (Triangulo e Quadrado) 
        // em uma única lista do tipo da classe mãe (Forma)
        List<Forma> formas = [
            new Triangulo(),
            new Quadrado()
        ];
        
        foreach(Forma figura in formas)
        {
            figura.lados();
        }
    
    }
}