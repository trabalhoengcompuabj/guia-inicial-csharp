class operadores{
    static void Main() {

        //Para entender a maneira como funcionam os operadores em C# vamos exemplificar cada um deles.



        //Operadores Aritmeticos:
        //Servem para fazer calculos matematicos, eles pegam os numeros, fazem a operacao e devolvem o resultado. 
        //O operador + faz a soma.
        int soma = 1 + 1;

        //O operador - faz a subtracao.
        int subtracao = 2 - 1;

        //O operador * faz a multiplicacao.
        int multiplicacao = 2 * 2;

        //O operador / faz a divisao.
        int divisao = 4 / 2;

        //O operador % faz o resto da divisao, ou seja, o que sobra da divisao.
        int resto = 5 % 2;



        //Operadores de Incremento e Decremento:
        //Servem para aumentar ou diminuir o valor de uma variavel em 1, sao muito usados em loops e contadores.
        //O operador ++ aumenta o valor da variavel em 1.
        int incremento = 1;
        incremento++;

        //O operador -- diminui o valor da variavel em 1.
        int decremento = 1;
        decremento--;

        //Operadores de Atribuicao:
        //Servem para atribuir valores a variaveis, eles pegam o valor da direita e colocam na variavel da esquerda.
        //O operador = atribui o valor da direita a variavel da esquerda.
        int atribuicao = 1;

        //O operador += soma o valor da direita a variavel da esquerda.
        int atribuicao_soma = 1;
        atribuicao_soma += 1;

        //O operador -= subtrai o valor da direita a variavel da esquerda.
        int atribuicao_subtracao = 1;
        atribuicao_subtracao -= 1;

        //O operador *= multiplica o valor da direita a variavel da esquerda.
        int atribuicao_multiplicacao = 1;
        atribuicao_multiplicacao *= 2;

        //O operador /= divide o valor da direita a variavel da esquerda.
        int atribuicao_divisao = 2;
        atribuicao_divisao /= 2;

        //O operador %= pega o resto da divisao do valor da direita e atribui a variavel da esquerda.
        int atribuicao_resto = 5;
        atribuicao_resto %= 2;

        

        //Operadores de Comparacao:
        //Servem para comparar valores, eles pegam os valores e devolvem um booleano (true ou false) dependendo do resultado da comparacao.
        //O operador == compara se os valores sao iguais.
        int comparacao_igual = 1;
        bool resultado_igual = comparacao_igual == 1;

        //O operador != compara se os valores sao diferentes.
        int comparacao_diferente = 1;
        bool resultado_diferente = comparacao_diferente != 2;

        //O operador > compara se o valor da esquerda eh maior que o valor da direita.
        int comparacao_maior = 2;
        bool resultado_maior = comparacao_maior > 1;

        //O operador < compara se o valor da esquerda eh menor que o valor da direita.
        int comparacao_menor = 1;
        bool resultado_menor = comparacao_menor < 2;

        //O operador >= compara se o valor da esquerda eh maior ou igual ao valor da direita.
        int comparacao_maior_igual = 2;
        bool resultado_maior_igual = comparacao_maior_igual >= 2;

        //O operador <= compara se o valor da esquerda eh menor ou igual ao valor da direita.
        int comparacao_menor_igual = 1;
        bool resultado_menor_igual = comparacao_menor_igual <= 1;

        

        //Operadores Logicos:
        //Servem para combinar comparacoes, eles pegam os valores booleanos e devolvem um booleano dependendo do resultado da operacao.
        //O operador && (E) devolve true se ambos os valores forem true.
        bool logico_e = true && true;

        //O operador || (OU) devolve true se pelo menos um dos valores for true.
        bool logico_ou = true || false;

        //O operador ! (NAO) inverte o valor do booleano, se for true vira false e vice versa.
        bool logico_nao = !true;

        

        //Operadores Ternarios:
        //Servem para fazer comparacoes e atribuir valores dependendo do resultado da comparacao, eles pegam os valores e devolvem um valor dependendo do resultado da comparacao.
        //O operador ? : (Ternario) devolve o valor da esquerda se a comparacao for true e o valor da direita se a comparacao for false.
        int idade = 18;
        string resultado_ternario = idade >= 18 ? "Maior de idade" : "Menor de idade";

        

        Console.WriteLine($"Soma: {soma}\n");
        Console.WriteLine($"Subtracao: {subtracao}\n");
        Console.WriteLine($"Multiplicacao: {multiplicacao}\n");
        Console.WriteLine($"Divisao: {divisao}\n");
        Console.WriteLine($"Resto: {resto}\n");
        Console.WriteLine($"Incremento: {incremento}\n");
        Console.WriteLine($"Decremento: {decremento}\n");
        Console.WriteLine($"Atribuicao: {atribuicao}\n");
        Console.WriteLine($"Atribuicao Soma: {atribuicao_soma}\n");
        Console.WriteLine($"Atribuicao Subtracao: {atribuicao_subtracao}\n");
        Console.WriteLine($"Atribuicao Multiplicacao: {atribuicao_multiplicacao}\n");
        Console.WriteLine($"Atribuicao Divisao: {atribuicao_divisao}\n");
        Console.WriteLine($"Atribuicao Resto: {atribuicao_resto}\n");
        Console.WriteLine($"Comparacao Igual: {resultado_igual}\n");
        Console.WriteLine($"Comparacao Diferente: {resultado_diferente}\n");
        Console.WriteLine($"Comparacao Maior: {resultado_maior}\n");
        Console.WriteLine($"Comparacao Menor: {resultado_menor}\n");
        Console.WriteLine($"Comparacao Maior Igual: {resultado_maior_igual}\n");
        Console.WriteLine($"Comparacao Menor Igual: {resultado_menor_igual}\n");
        Console.WriteLine($"Logico E: {logico_e}\n");
        Console.WriteLine($"Logico OU: {logico_ou}\n");
        Console.WriteLine($"Logico NAO: {logico_nao}\n");
        Console.WriteLine($"Resultado Ternario: {resultado_ternario}\n");

    }
}