using System;

namespace ExercicioMatrizes // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            int[,] mat;

            string[] matriz = Console.ReadLine().Split(' ');
            int n = int.Parse(matriz[0]);
            int m = int.Parse(matriz[1]);
            mat = new int[n, m];

            for (int i = 0; i < n; i++) {

                string[] value = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++) {
                    mat[i, j] = int.Parse(value[j]);
                }
            }
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                for (int j = 0; j < m; j++) {
                    if (mat[i, j] == number) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }                        
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < m - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < n - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}