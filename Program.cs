using System;

namespace Exercicio_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para ler dois números inteiros M e N, e depois ler" + "\n" + "ma matriz de M linhas por N colunas contendo números inteiros, " + "\n" + "podendo haver repetições.Em seguida, ler um número inteiro X que" + "\n" + "pertence à matriz.Para cada ocorrência de X, mostrar os valores à" + "\n" + "esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Insira o valor de Linhas desejas na Matriz: ");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Insira o valor de Colunas desejas na Matriz: ");
            int coluna = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matz = new int[linha, coluna];

            for (int l = 0; l < linha; l++)
            {
                Console.Write($"Insira os números desejados para a linha: #{l} ");
                string[] valor = Console.ReadLine().Split(" ");
                for (int c = 0; c < coluna; c++)
                {
                    matz[l, c] = int.Parse(valor[c]);
                }
            }

            Console.WriteLine();
            Console.Write("Insira uma posição na Matriz que deseja consultar: ");
            int consulta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int r = 0; r < linha; r++)
            {
                for(int o = 0; o < coluna; o++)
                {
                    if (matz[r, o] == consulta)
                    {
                        Console.WriteLine();
                        Console.WriteLine("A posição escolhida foi: " + r + "," + o + ";");
                        Console.WriteLine();
                        if (o > 0)
                        {
                            Console.WriteLine("A Esqueda temos o nº: " + matz[r, o - 1]);
                            Console.WriteLine();
                        }
                        if (r > 0)
                        {
                            Console.WriteLine("Acima temos o nº: " + matz[r - 1, o]);
                            Console.WriteLine();
                        }
                        if (o < coluna - 1)
                        {
                            Console.WriteLine("A Direita temos o nº: " + matz[r, o + 1]);
                            Console.WriteLine();
                        }
                        if (r < linha - 1)
                        {
                            Console.WriteLine("E Abaixo temos o nº: " + matz[r + 1, o]);
                            Console.WriteLine();
                        }

                    }
                }
            }
        }
    }
}
