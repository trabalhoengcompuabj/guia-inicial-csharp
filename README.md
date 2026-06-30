![logo](./.github/assets/logo_guia_inicial.png)

![.NET versão](https://img.shields.io/badge/.NET-10.0-blue) ![Licença MIT](https://img.shields.io/badge/license-MIT-green)

Este repositório foi criado para servir como um mini-curso direto e prático da linguagem C#. Se você está começando agora e quer entender desde a estrutura mais básica até os pilares da programação orientada a objetos, este guia foi feito para você. A ideia aqui é que você leia acompanhando a evolução lógica dos conceitos. Todos os códigos completos utilizados nos exemplos estão anexados neste repositório.

## Índice

* [O que é C#](#o-que-é-c)
* [Principais áreas de aplicação](#principais-áreas-de-aplicação)
* [Vantagens e desvantagens](#vantagens-e-desvantagens)
* [Introdução à Programação Orientada a Objetos](#introdução-à-programação-orientada-a-objetos)
* [Estrutura básica de um programa](#estrutura-básica-de-um-programa)
* [Fundamentos](#fundamentos)
  * [Hello World](#hello-world)
  * [Variáveis e Tipos](#variáveis-e-tipos)
  * [Entrada e Saída](#entrada-e-saída)
  * [Operadores](#operadores)
  * [Estruturas Condicionais](#estruturas-condicionais)
  * [Funções Básicas](#funções-básicas)
  * [Loops](#loops)
  * [Arrays](#arrays)
  * [Listas](#listas)
* [Programação Orientada a Objetos](#programação-orientada-a-objetos)
  * [Classes e Objetos](#classes-e-objetos)
  * [Herança](#herança)
  * [Polimorfismo](#polimorfismo)
  * [Encapsulamento](#encapsulamento)
  * [Abstração](#abstração)

## O que é C#

O C# (lê-se *C-Sharp*) é uma linguagem de programação moderna, criada pela Microsoft no início dos anos 2000. Ela roda na plataforma .NET e é fortemente tipada, o que significa que o compilador é rigoroso com os tipos de dados que você usa, ajudando a evitar erros bobos antes mesmo do programa rodar. É uma linguagem compilada, transformando o código que você escreve em uma linguagem otimizada que a máquina entende e executa com alta performance.

## Principais áreas de aplicação

Por ser extremamente versátil, o C# abre muitas portas no mercado de trabalho. Com ele, você pode construir:
* **Aplicações desktop:** Softwares robustos para Windows.
* **Aplicações web:** Sites, portais e sistemas dinâmicos utilizando o ASP.NET.
* **APIs:** Backends que conectam bancos de dados a aplicativos de celular e interfaces web.
* **Jogos:** O C# é a linguagem nativa da Unity, uma das maiores engines de criação de jogos do mundo.
* **Aplicações empresariais e em nuvem:** Sistemas gigantescos, seguros e escaláveis rodando em servidores como o Microsoft Azure.

## Vantagens e desvantagens

Como toda tecnologia, o C# tem seus pontos fortes e fracos.

**Vantagens:**
* Tem uma sintaxe muito organizada, limpa e parecida com outras linguagens famosas (como Java e C++).
* Facilita muito a manutenção do código a longo prazo.
* É uma das melhores linguagens do mundo para aplicar Orientação a Objetos.
* Possui uma documentação oficial fantástica e uma comunidade gigante.
* Integração perfeita com todo o ecossistema .NET.

**Desvantagens:**
* O ecossistema é muito grande e cheio de ferramentas, o que pode assustar quem está dando os primeiros passos.
* Pode consumir um pouco mais de memória do que linguagens de mais baixo nível, devido ao seu gerenciador automático de lixo (Garbage Collector).
* Apesar de rodar em Linux e Mac hoje em dia, ainda é muito dependente das decisões do ambiente Microsoft.

## Introdução à Programação Orientada a Objetos

O C# é, na sua essência, uma linguagem Orientada a Objetos (POO). Isso significa que, em projetos reais, o código é organizado simulando coisas do mundo real (objetos) que interagem entre si. 

Primeiro vamos passar por toda a lógica de programação, aprendendo as regras básicas do C#. Só depois entraremos fundo nos pilares da orientação a objetos. 

Se você já sabe lógica e quer ir direto para a parte avançada, [clique aqui para ir para a seção de Programação Orientada a Objetos](#programação-orientada-a-objetos).

## Estrutura básica de um programa

Antes de escrevermos qualquer lógica, você precisa entender o "esqueleto" que todo arquivo C# precisa ter para funcionar. Ele tem essa cara:

```csharp
using System;

public class NomeArquivo
{
    public static void Main()
    {
        // Seu código vai aqui
    }
}

```

* **`using`**: É como você importa "caixas de ferramentas" prontas da linguagem. O `System`, por exemplo, traz comandos básicos do sistema.
* **`class`**: No C#, absolutamente todo código precisa estar dentro de uma classe.
* **`Main`**: É o ponto de partida. Quando você manda o programa rodar, o computador procura a palavra `Main` e começa a executar os comandos que estão dentro dela.
* **Chaves** **`{ }`** **e Ponto e Vírgula** **`;`**: As chaves agrupam os blocos de código. O ponto e vírgula avisa que o seu comando daquela linha acabou.

## Fundamentos

### Hello World

O primeiro contato com qualquer linguagem é fazer o computador exibir uma mensagem na tela. Isso serve para testar se o seu ambiente de desenvolvimento está configurado corretamente.

```csharp
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello, world");
    }
}

```

O `Console` representa a tela do terminal. Quando chamamos `.WriteLine()`, estamos mandando ele escrever o texto entre as aspas na tela e, logo em seguida, pular para a linha de baixo.
Se você usar apenas `Console.Write()`, ele escreve o texto, mas o cursor continua piscando na mesma linha, colando o próximo texto que vier logo na sequência.

### Variáveis e Tipos

Variáveis são espaços na memória do computador onde você guarda informações. Como o C# é fortemente tipado, você precisa dizer exatamente qual é o "formato" da caixa antes de colocar um valor dentro dela.

| Tipo | O que guarda |
| --- | --- |
| **`int`** | Números inteiros comuns. |
| **`long`** | Números inteiros gigantescos. |
| **`double`** | Números fracionados (o padrão para cálculos). |
| **`float`** | Números fracionados (ocupa menos memória, comum em jogos). |
| **`decimal`** | Números fracionados com precisão absoluta (obrigatório para dinheiro). |
| **`bool`** | Lógica verdadeira ou falsa (`true` ou `false`). |
| **`char`** | Um único caractere (letra ou símbolo). |
| **`string`** | Textos e frases completas. |


Aqui criamos duas caixas de números inteiros. Repare que o `long` exige a letra `L` no final do número para avisar o computador que aquele valor é excepcionalmente grande.

```csharp
int ano_de_nascimento = 2002;
long populacao_mundial = 8301598750L;

```

Para números com vírgula, o `double` é o mais comum e não exige letras. O `float` pede a letra `f`, e o `decimal`, que é imune a pequenos erros de arredondamento e perfeito para mexer com saldos bancários, pede a letra `m`.

```csharp
double altura = 1.75;
float velocidade = 80.5f;
decimal saldo_bancario = 1620.50m;

```

Textos seguem uma regra estrita: se for apenas um caractere (`char`), usamos aspas simples. Se for um texto maior (`string`), usamos obrigatoriamente aspas duplas.

```csharp
char letra = 'm';
string frase = "Introducao a engenharia da computacao";

```

No C# moderno, temos a regra do `var`. Se o valor que você está atribuindo já deixa óbvio o que ele é (como "Matheus" que obviamente é um texto), você usa `var` e o próprio compilador descobre automaticamente que a variável será do tipo `string`.

```csharp
var nome = "Matheus";

```


### Entrada e Saída

A entrada e saída servem para o programa conversar com quem está no teclado. O programa exibe uma pergunta, o usuário digita uma resposta, e o programa guarda isso em uma variável. O detalhe é que tudo o que o terminal recebe, ele recebe no formato de texto.

```csharp
Console.WriteLine("Insira seu nome:"); 
String nomeUsuario = Console.ReadLine();

```

O `Console.ReadLine()` faz o programa pausar e ficar esperando o usuário digitar algo e apertar *Enter*. O que foi digitado vai direto para dentro da variável.

```csharp
Console.WriteLine("Insira sua idade:");
String idadeUsuario = Console.ReadLine();
int idade = int.Parse(idadeUsuario);

```

Aqui está o pulo do gato das conversões. O programa pegou a idade, mas guardou como texto (`String`). Para conseguirmos fazer contas com essa idade no futuro, precisamos convertê-la para número. É aí que entra o `int.Parse()`, que lê os caracteres e os transforma em um número real na memória. O mesmo serve para `double.Parse()` se fosse um número com vírgula.

```csharp
Console.WriteLine($"Nome do usuário: {nomeUsuario}\n");
Console.WriteLine($"Idade do usuário: {idade} anos\n");

```

Para imprimir as variáveis misturadas com o texto de forma limpa, usamos o caractere `$` antes das aspas da string. Isso se chama Interpolação, e permite que você injete as variáveis diretamente no meio da frase usando chaves `{ }`.

### Operadores

Operadores são os símbolos que usamos para manipular e comparar os dados do nosso programa. Eles se dividem em algumas categorias principais:

```csharp
// Aritméticos: Fazem a matemática básica
int soma = 1 + 1;
int divisao = 4 / 2;
int resto = 5 % 2; // Pega apenas a sobra de uma divisão inteira

```

```csharp
// Incremento e Decremento: Aumentam ou diminuem o valor em exatamente 1
int incremento = 1;
incremento++; 

```

```csharp
// Atribuição: Atalhos para modificar uma variável usando ela mesma
int a = 10;
a += 5; // É a mesma coisa que dizer: a = a + 5;

```

```csharp
// Comparação: Avaliam valores e sempre devolvem true (verdadeiro) ou false (falso)
bool resultado_igual = (10 == 10);
bool resultado_diferente = (10 != 5);
bool resultado_maior = (10 > 5);

```

```csharp
// Lógicos: Combinam duas ou mais comparações
bool logico_e = (true && true);   // O && exige que TUDO seja verdadeiro
bool logico_ou = (true || false); // O || exige que PELO MENOS UM seja verdadeiro
bool logico_nao = !true;          // O ! inverte o resultado (true vira false)

```
# Tabela com todos os operadores:

| Categoria | Operador | Descrição | Exemplo | Resultado |
| :--- | :---: | :--- | :--- | :--- |
| **Aritméticos** | `+` | Soma valores ou concatena strings | `5 + 3` | `8` |
| | `-` | Subtrai valores | `10 - 4` | `6` |
| | `*` | Multiplica valores | `3 * 4` | `12` |
| | `/` | Divide valores | `10 / 2` | `5` |
| | `%` | Resto da divisão (Módulo) | `5 % 2` | `1` |
| | `++` | Incremento (soma 1) | `x++` | Aumenta `x` em 1 |
| | `--` | Decremento (subtrai 1) | `x--` | Diminui `x` em 1 |
| **Atribuição** | `=` | Atribui um valor | `x = 10` | `x` passa a ser 10 |
| | `+=` | Soma e atribui | `x += 5` | Igual a `x = x + 5` |
| | `-=` | Subtrai e atribui | `x -= 3` | Igual a `x = x - 3` |
| **Comparação** | `==` | Igual a | `5 == 5` | `true` |
| | `!=` | Diferente de | `5 != 3` | `true` |
| | `>` | Maior que | `10 > 20` | `false` |
| | `<` | Menor que | `10 < 20` | `true` |
| | `>=` | Maior ou igual a | `5 >= 5` | `true` |
| | `<=` | Menor ou igual a | `4 <= 2` | `false` |
| **Lógicos** | `&&` | Operador E (AND) | `true && false` | `false` |
| | `\|\|` | Operador OU (OR) | `true \|\| false` | `true` |
| | `!` | Operador NÃO (NOT) | `!true` | `false` |
| **Especiais** | `? :` | Condicional Ternário | `(x > 5) ? "Sim" : "Não"`| Retorna "Sim" se x > 5 |
| | `?.` | Navegação Segura (Null-conditional) | `obj?.Nome` | Acessa se `obj` não for nulo |
| | `??` | Coalescência Nula | `nome ?? "Anônimo"` | Usa "Anônimo" se `nome` for nulo |
### Estruturas Condicionais

É aqui que o programa começa a tomar decisões e criar caminhos diferentes com base em avaliações lógicas.

```csharp
double nota = 6.5;
        
if(nota >= 7) {
    Console.WriteLine("Voce foi aprovado");
}

```

O `if` ("se") avalia a condição entre os parênteses. Se a nota for maior ou igual a 7, ele entra no bloco e executa o código. Se não for, ele simplesmente ignora essa parte.

```csharp
else if (nota >= 5) {
    Console.WriteLine("Voce esta de recuperaçao");
}

```

O `else if` ("senão se") só é chamado se a condição de cima falhou. Se a nota não for maior que 7, ele verifica se pelo menos é maior que 5, abrindo um novo caminho exclusivo para a recuperação.

```csharp
else {
    Console.WriteLine("Voce esta reprovado");
}

```

O `else` ("senão") não possui testes. Ele é a saída de emergência. Se absolutamente nenhuma das condições acima for verdadeira, o programa cai aqui automaticamente.
Vale mencionar que, se você estiver testando valores exatos de uma variável (como escolhas de um menu 1, 2 ou 3), existe também a estrutura `switch`, que deixa o código mais limpo do que vários `else if` encadeados.

### Funções Básicas

Funções (ou métodos) existem para você parar de repetir o mesmo código em vários lugares do sistema. Você escreve um bloco que resolve um problema específico uma vez só, e sempre que precisar daquela solução, basta chamar o nome da função. Elas podem ou não pedir parâmetros de entrada, e podem ou não devolver uma resposta no final (retorno).

```csharp
public static void ShowMessage()
{
    Console.WriteLine("Função executada -> isso foi void");
}

```

Quando declaramos uma função com a palavra `void`, estamos dizendo que ela apenas faz uma ação interna. Ela executa o trabalho dela e acaba ali, sem devolver nenhuma informação para quem a chamou.

```csharp
public static int GetAge()
{
    return 18;
}

public static string GetName()
{
    return "Caio";
}

```

Se trocarmos o `void` pelo nome de um tipo (como `int` ou `string`), a função passa a ter um retorno obrigatório. Depois de executar sua lógica interna, ela precisa usar a palavra `return` para devolver o dado prometido.

```csharp
FuncoesBasicas.ShowMessage();
Console.WriteLine(FuncoesBasicas.GetName());

```

Para usar a função em outra parte do código, basta chamá-la pelo nome acompanhada de parênteses. Se a função tiver retorno, podemos inclusive colocar ela direto dentro de um `Console.WriteLine` ou salvar seu resultado em uma variável.

### Loops

Loops são estruturas de repetição. Eles fazem o computador rodar a mesma parte do código várias vezes, o que é ótimo para poupar trabalho manual. Cada um tem um momento ideal para ser usado.

```csharp
for (int numero = 1; numero <= 10; numero = numero + 1)
{
    Console.WriteLine(numero);
}

```

O **`for`** é usado quando você sabe exatamente o limite da repetição. Ele cria a variável que vai contar (`numero = 1`), diz até quando o loop deve durar (`numero <= 10`) e como a variável vai aumentar a cada volta (`numero + 1`). Tudo organizado na mesma linha.

```csharp
int regressivo = 10;
while (regressivo >= 0) 
{
    Console.WriteLine(regressivo);
    regressivo = regressivo - 1;
}

```

O **`while`** é ideal para quando a repetição depende de uma condição e você não tem certeza de quantas vezes vai rodar. O perigo dele é que, se você esquecer de mudar o valor da variável de controle lá dentro (`regressivo - 1`), ele pode rodar para sempre e travar o programa.

```csharp
int contagem = 0;
do
{
    Console.WriteLine(contagem);
    contagem = contagem + 1;
} while (contagem <= 10);

```

O **`do while`** é bem parecido com o `while`, mas a diferença é que ele executa o bloco de código primeiro, e só depois testa a condição. Isso garante que o código lá de dentro rode pelo menos uma única vez, independente da condição.

```csharp
string[] frutas = {"Uva", "Banana", "Laranja"};
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

```

O **`foreach`** é o loop especialista em ler listas e grupos de dados. Ele passa item por item da sua coleção (`frutas`), extrai o valor para uma variável temporária (`fruta`) e roda o código. Quando os itens acabam, ele para sozinho, sem você precisar gerenciar números e limites.

### Arrays

Arrays são coleções de dados de tamanho fixo. Você aloca o espaço na memória de antemão e guarda valores do mesmo tipo de forma enfileirada. Cada valor ganha um endereço numérico chamado **índice**.

```csharp
int[] numeros = new int[3];

```

Aqui criamos um array de inteiros com espaço exato para 3 elementos. Depois de criado, esse tamanho não pode aumentar nem diminuir.

```csharp
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;

```

A regra de ouro da computação é que as posições (índices) **começam sempre no zero**. Portanto, o primeiro elemento ocupa a posição `0`, e um array de 3 espaços vai apenas até o índice `2`.

```csharp
string[] dias = {"segunda", "terça", "quarta", "domingo", "sexta"};
dias[3] = "quinta";

```

Você também pode criar o array já preenchido. O tamanho dele será a quantidade de itens que você colocou. Para alterar um valor que já existe, basta acessar o índice dele. Na linha de cima, substituímos "domingo" por "quinta".

```csharp
Array.Sort(dias);
Console.WriteLine(dias.Length);

```

A linguagem te fornece ferramentas prontas. O `Array.Sort()` organiza seu array (em ordem crescente ou alfabética), e a propriedade `.Length` te devolve a quantidade exata de espaços daquele array.

### Listas

As Listas (`List`) têm o mesmo objetivo dos Arrays, mas com uma vantagem imensa: elas são totalmente dinâmicas. Você não precisa definir um tamanho antes. Você pode ir adicionando e removendo elementos e a lista ajusta a memória automaticamente.

```csharp
List<string> jogos = new List<string>();

```

Para usar listas, declaramos o tipo de dado que ela vai guardar dentro dos sinais de menor e maior `< >`. Aqui nasce uma lista de textos vazia.

```csharp
jogos.Add("Jogo quadrado");

string[] adicional = {"Zelda", "Pokemon", "Terraria"};
jogos.AddRange(adicional);

```

O método `.Add()` empurra um elemento novo para o final da fila, aumentando o tamanho da lista. Se você tem um grupo grande de elementos, o `.AddRange()` adiciona todos eles de uma só vez.

```csharp
jogos[0] = "Minecraft"; 
Console.WriteLine(jogos.Count);

```

O acesso pela posição (índice) funciona da mesma forma que os Arrays. A diferença sutil na hora de verificar o tamanho é que, enquanto Arrays usam `.Length`, as Listas utilizam `.Count`.

```csharp
jogos.Remove("Zelda");
jogos.RemoveAt(1);

```

A mágica da lista está na remoção. Você pode mandar remover um elemento passando exatamente o valor dele (`.Remove`), ou dizendo qual índice deve sumir (`.RemoveAt`). Quando você faz isso, a lista deleta o elemento e puxa todos os outros itens para frente, tapando o buraco e não deixando posições vazias na memória.

## Programação Orientada a Objetos

Entramos na arquitetura do código. Na POO, paramos de pensar em variáveis soltas e começamos a modelar o nosso sistema desenhando representações inteligentes de coisas do mundo real, dando características e ações para elas.

### Classes e Objetos

A classe e o objeto são as pedras fundamentais. A **Classe** é um projeto, um rascunho de papel ou um "molde" que diz o que algo deve ser. O **Objeto** (ou instância) é quando pegamos esse molde e criamos uma coisa física, independente e que existe de verdade na memória do computador.

```csharp
class Pessoa
{
    public string Nome;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos.");
    }
}

```

Aqui criamos o nosso molde. Toda pessoa que existir nesse sistema vai ter um atributo `Nome`, um atributo `Idade`, e vai saber realizar a ação de `Apresentar` usando os seus próprios dados.

```csharp
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Matheus";
pessoa1.Idade = 19;
pessoa1.Apresentar();

```

O operador `new` é o cara que constrói o objeto a partir da classe. Nesse momento, o Matheus passa a existir na memória.

```csharp
Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Vini Jr.";
pessoa2.Idade = 25;
pessoa2.Apresentar();

```

Como temos um molde bem feito, podemos reutilizar a estrutura da classe para criar um segundo objeto completamente independente. Mudar o nome do Vini Jr. não afeta em nada a memória alocada para o Matheus.

### Herança

A Herança existe para reaproveitar estruturas prontas. Imagine que você tem uma classe mãe. Você pode criar classes filhas que herdam todas as características da mãe, evitando que você digite o mesmo código em vários lugares do sistema.

```csharp
class Eletrodomestico
{
    public string marca;
    public bool ligado;
}

```

A classe `Eletrodomestico` é a nossa mãe. Afinal, qualquer eletrodoméstico do mundo possui uma marca fabricante e pode estar ligado ou desligado.

```csharp
class Fogao : Eletrodomestico
{
    public float temperatura;
}

class Ventilador : Eletrodomestico
{
    public int velocidade;
}

```

O sinal de dois pontos `:` faz a mágica da herança. Lemos isso como "O Fogão é um Eletrodoméstico". Sem que a gente precise digitar de novo, o fogão e o ventilador acabaram de herdar a `marca` e o estado `ligado`. Ao mesmo tempo, cada um deles criou as suas características exclusivas (`temperatura` para o fogão, `velocidade` para o ventilador).

```csharp
Fogao fogao = new Fogao();
fogao.marca = "Electrolux";
fogao.temperatura = 0;

```

Quando criamos o objeto real do Fogão, conseguimos definir perfeitamente a sua marca (que veio da classe mãe) e a sua temperatura (que pertence apenas a ele).

### Polimorfismo

O nome já diz tudo: "Muitas formas". Esse conceito permite que a classe mãe dê uma mesma ordem para várias classes filhas, e cada filha saiba executar essa mesma ordem de um jeito completamente diferente da sua irmã.

```csharp
class Forma
{
    public virtual void lados()
    {
        Console.WriteLine("A forma tem X lados");
    }
}

```

Na classe mãe, declaramos o método usando a palavra `virtual`. Isso é como a mãe dizer: "Eu tenho um jeito padrão de fazer as coisas, mas permito que minhas filhas mudem esse comportamento se quiserem".

```csharp
class Triangulo : Forma
{
    public override void lados()
    {
        Console.WriteLine("O triângulo tem 3 lados");
    }
}

```

Nas classes filhas, usamos a palavra `override` (sobrescrever). O Triângulo herda o método da Forma, mas apaga o comportamento da mãe e cria o seu próprio.

```csharp
List<Forma> formas = [
    new Triangulo(),
    new Quadrado()
];
        
foreach(Forma figura in formas)
{
    figura.lados();
}

```

O poder do Polimorfismo entra em cena aqui. Como o triângulo e o quadrado herdam da Forma, podemos juntar objetos diferentes em uma mesma lista. Quando o loop manda cada `figura` desenhar seus `lados()`, ele não precisa se importar com quem elas são. A própria linguagem entende qual objeto está rodando no momento e dispara o comportamento correto de cada um.

### Encapsulamento

O Encapsulamento é a segurança dos dados. É o ato de esconder as variáveis da sua classe, proibindo que outros arquivos modifiquem elas diretamente. Quem quiser mudar os dados, vai ter que passar por regras de validação.

```csharp
class ContaBancaria
{
    private double saldo;

```

A palavra `private` diz que o `saldo` pertence só a essa conta e não pode ser tocado ou visualizado de fora de jeito nenhum. Qualquer tentativa de fazer `conta.saldo = 5000` em outro arquivo vai gerar um erro travando a compilação.

```csharp
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

```

Como o saldo está trancado, a única saída é criar um método `public`. Esse método age como o caixa do banco. Você entrega o dinheiro e o método avalia (`if valor > 0`). Se a regra de segurança do depósito for respeitada, ele mesmo altera a variável interna, mantendo a integridade da sua classe. O mesmo conceito também é aplicado moderno e mais limpo hoje em dia usando "Properties" (get e set).

### Abstração

A Abstração é focar no "O que o objeto faz", escondendo totalmente o "Como ele faz". Na programação, criamos Classes Abstratas ou Interfaces que definem as obrigações que as classes reais vão precisar cumprir.

```csharp
abstract class Aparelho
{
    public abstract void ligar();
}

```

A palavra `abstract` diz que `Aparelho` é apenas uma ideia conceitual. O C# proíbe você de instanciar isso (não dá para fazer `new Aparelho()`). E veja que o método `ligar` termina com um ponto e vírgula. Não tem código ali dentro. Ele está criando uma regra: "Quem quiser ser um Aparelho no meu sistema, vai ter que dar um jeito de implementar a ação de ligar".

```csharp
interface ITomada
{
    void conectarTomada();
}

```

As interfaces, que começam com a letra `I`, funcionam como contratos de habilidades. Elas definem ações puras, sem nenhuma lógica dentro. E o legal é que uma classe só pode herdar uma única classe mãe abstrata, mas pode assinar várias interfaces de uma só vez (podendo ser um equipamento de `ITomada` e `IWifi` ao mesmo tempo).

```csharp
class Radio : Aparelho, ITomada
{
    public override void ligar()
    {
        Console.WriteLine("Rádio ligado");
    }

    public void conectarTomada()
    {
        Console.WriteLine("Rádio conectado na tomada");
    }
}

```

Por fim, nasce a classe concreta do Rádio. Como ele estende a classe `Aparelho`, ele é obrigado a usar o `override` e escrever a lógica real de como aquele equipamento funciona para ligar. Ao mesmo tempo, ele assina o contrato da `ITomada`, o que o obriga a implementar o método de conectar.
