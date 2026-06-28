
/*
O Encapsulamento é o pilar da POO usado para proteger os dados (atributos) 
de um objeto, impedindo que eles sejam modificados diretamente de forma externa ou indevida.
O acesso a esses dados só ocorre por meio de métodos públicos específicos que validam e
filtram as alterações (regras de negócio).

Imagine uma conta bancária. Se qualquer outra parte do código pudesse alterar 
o saldo diretamente, alguém poderia definir um saldo negativo ou arbitrário sem nenhuma validação. 
Com o encapsulamento, tornamos o saldo privado e controlamos sua alteração apenas por depósitos válidos.
*/



class ContaBancaria
{
    // Atributo privado (não pode ser acessado diretamente)
    private double saldo;

    // Método público para depositar dinheiro
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo = saldo + valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }

    /*
    Com essa estrutura, a única maneira de alterar a variável "saldo" 
    é passando pelo método de validação "Depositar". Ele avalia se o valor é positivo: 
    se for válido, o saldo é atualizado; caso contrário, a alteração é rejeitada. 
    Isso garante a integridade dos dados.
    */



    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
    }
}

class Programa
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        /*
        Não é possível fazer:

        conta.saldo = 1000

        Se fizer isso vai resultar em erro, pois saldo é privado.
        */

        conta.Depositar(500); // -> Resultado impresso: Depósito de R$ 500,00 realizado.
        conta.Depositar(-100); // -> Resultado impresso: O valor do depósito deve ser maior que zero.

        conta.MostrarSaldo(); // -> Resultado impresso: Saldo atual: R$ 500,00
    }
}