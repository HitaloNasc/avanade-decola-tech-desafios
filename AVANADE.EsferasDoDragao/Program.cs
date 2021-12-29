using System;
using System.Collections.Generic;
using System.Text;
class Xenlongao
{
    static void Main(string[] args)
    {
        // [Entrada] - número de casos
        int C = int.Parse(Console.ReadLine());

        // [Teste] - validação caso a caso
        for (int i = 0; i < C; i++)
        {
            // [Entrada] - número de esferas
            int num = int.Parse(Console.ReadLine());

            // Verificar quantidade de esferas cujo o total de divisores não é ímpar
            int totalEsferas = 0;
            for (int j = 1; j <= num; j++)
            {
                if (totalDivisores(j) % 2 == 0)
                {
                    totalEsferas++;
                }
            }

            // [Saída] - Total de esferas a serem procuradas
            Console.WriteLine(totalEsferas);
        }

    }

    private static int totalDivisores(int num)
    {
        int resultado = 0;
        // se for primo há apenas dois divisores
        if (checkPrimo(num))
        {
            if (num == 1)
                resultado = 1;
            else
                resultado = 2;
        }
        // fatorar e calcular divisores
        else
        {
            // fatoração
            int fatorado = num;
            int[] fatores = new int[50];
            int indexFatores = 0;
            for (int divisor = 2; fatorado != 1; divisor++)
            {
                if (checkPrimo(divisor))
                {
                    fatores[indexFatores] = 0;
                    while (fatorado % divisor == 0)
                    {
                        fatores[indexFatores]++;
                        fatorado /= divisor;
                    }
                    indexFatores++;
                }
            }

            // calculo de divisores
            int divisores = 1;
            for (int i = 0; i < 50; i++)
            {
                if (fatores[i] != 0)
                {
                    divisores *= (fatores[i] + 1);
                }
            }
            resultado = divisores;
        }
        return resultado;
    }

    private static bool checkPrimo(int num)
    {
        int resultado = 0;
        if (num == 0)
        {
            resultado++;
        }
        else
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    resultado++;
                    break;
                }
            }
        }

        if (resultado == 0)
            return true;
        else
            return false;
    }

}