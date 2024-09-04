using System;
class Program
{
    static void Main()
    {
        // Defina o número a ser verificado
        int numero = 21;

        // Chamada da função para verificar se o número pertence à sequência de Fibonacci
        bool pertence = PertenceSequenciaFibonacci(numero);

        // Exibe a mensagem informando se o número pertence ou não à sequência
        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceSequenciaFibonacci(int num)
    {
        if (num < 0)
            return false;

        int a = 0;
        int b = 1;

        while (a < num)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a == num;
    }
}
