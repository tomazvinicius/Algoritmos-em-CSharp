using System;

namespace TrabalhoFinal
{
    class Program
    {

       public static void ExeUm()
        {
            int linha = 0, coluna = 0, inicio = -300, final = 300;
            int armazena;
            bool existe = false;
            int x = 0;

            Console.Write("\nInforme a quantidade de linhas:");
            linha = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de colunas:");
            coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna]; //Declarado uma matriz para armazenar as informações da linha e coluna de acordo os dados informados pelo usuario
            int[] auxiliar = new int[linha * coluna]; //Declarado um vetor que pode guardar o valor de linha * coluna


            for (int i = 0; i < linha; i++)
            {                                   //Laço declarado para linha(i) e coluna(j), assim armazenando a sua posição
                for (int j = 0; j < coluna; j++)
                {
                    do
                    {
                        existe = false; // Tipo booleano que serve como condição mediante a situação do problema
                        Random r = new Random(); //Responsável por gerar números aleatórios
                        armazena = r.Next(inicio, final); //Função de declarar valores que tem inicio, meio e fim, ou seja, números limitados


                        foreach (int numero in auxiliar) //Foi declarado uma nova variavel que tem a função de analisar cada elemento de um vetor
                        {
                            if (numero == armazena)
                            {
                                existe = true;
                            }
                        }
                    } while (existe == true);
                    if (existe == false)
                    {
                        matriz[i, j] = armazena;
                        auxiliar[x] = armazena;
                        x++;
                        Console.WriteLine($"O valor da {i + 1}° linha e da {j + 1}º coluna é: {matriz[i, j]}");
                    }
                }
            }
            Console.WriteLine("\nEscreva o número que deseja encontrar na matriz: ");
            int leia = int.Parse(Console.ReadLine());

            bool have = false;
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (have == false)
                    {
                        foreach (int search in auxiliar)
                        {
                            if (leia == matriz[i, j])
                            {
                                have = true;
                            }
                            if (have == true)
                            {
                                Console.WriteLine($"Seu número existe na matriz, a linha está na {i + 1}º posição e a coluna está na {j + 1}º posição");
                                break;
                            }
                        }
                    }
                }
            }
            if (have == false)
            {
                Console.WriteLine("Seu número não existe na matriz");
            }
        }
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine(" ------------------------------------------------ Selecione uma opção:  ------------------------------------------------ \n [1] Digite o número '1' para acessar o exercício 1 \n [2] Digite o número '2' para acessar o exercício 2");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você será redirecionado para a opção {opcao}...");
            switch (opcao)
            {
                case 1:
                    ExeUm();
                    break;
                           }
            Console.WriteLine("");
        }
    }
}
    

