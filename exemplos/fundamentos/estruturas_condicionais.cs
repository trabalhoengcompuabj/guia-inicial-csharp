using System;

//Programa que usa condicionais para saber a situação de um aluno de acordo com a nota
class Programa{
    static void Main(){
        //Exemplo de um leitor de notas
        Console.WriteLine("Insira sua nota para saber a situação: Aprovado, recuperação, reprovado");
        string inputnota = Console.ReadLine();

        /*Exemplo de um conversor de string (que é a forma como o 
        Console.ReadLine() consegue ler o que foi respondido*/
        double nota = double.Parse(inputnota);
        
        //Exemplo de uma condicional if ("se")
        if(nota >= 7){
             Console.WriteLine("Voce foi aprovado");
        }
        //Exemplo de uma condicional else if ("senão se")
        else if (nota >= 5){
             Console.WriteLine("Voce esta de recuperaçao");
        }
        //Exemplo de uma condicional else ("senão")
        else{
             Console.WriteLine("Voce esta reprovado");
            }
        }
    }
