using System;

public class Program
{
    public static void Main()
    {
        // Declaração de Variaveis
        int inteiro = 5;
        float numeroDecimal = 1.5f;
        string texto = "Texto de teste";
        bool verdadeiro = true;

        Console.WriteLine($"{inteiro}, {numeroDecimal}, {texto}, {verdadeiro}\n");


        // Array de Inteiros
        int[] numeros = { 1, 2, 3, 4, 5 };

        // Array de String
        string[] nomes = new string[] { "João", "Arthur", "Gabriel", "Lucas"};

        // Matriz 
        int[,] matriz1 = new int[3, 3];
        matriz1[0, 0] = 1;
        matriz1[0, 1] = 2;
        matriz1[0, 2] = 3;

        // Ou assim tambem
        int[,] matriz2 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };


        // Estrutura de Condição
        int idade = 21;

        if (idade >= 18) {
            Console.WriteLine("Você é maior de idade.\n");
        } else if (idade >= 60) {
            Console.WriteLine("Você é idoso.\n");
        } else {
            Console.WriteLine("Você é menor de idade.\n");
        }


        // Estrutura de Repetição
        int contador = 0;

        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"Contador: {contador}");
            contador++;
        }

        // Switch Case
        int diaSemana = 3;

        switch (diaSemana) {
            case 1:
                Console.WriteLine("\nDomingo.");
                break;
            case 2:
                Console.WriteLine("\nSegunda-feira.");
                break;
            case 3:
                Console.WriteLine("\nTerça-feira.");
                break;
            default:
                Console.WriteLine("\nDia inválido.");
                break;
        }
    }
}