using System.Security.AccessControl;

namespace ExercicioMatriz {
    internal class Program {
        static void Main(string[] args) {

            string[] num_mat = Console.ReadLine().Split(' ');
            int m = int.Parse(num_mat[0]);
            int n = int.Parse(num_mat[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {

                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) { 
                    
                    if (x == mat[i, j]) {
                        int left, rigth, up, down;

                        Console.WriteLine($"Position:{i}, {j}: ");

                        if (j > 0) {
                            left = mat[i, j - 1];
                            Console.WriteLine($"Left: {left}");
                        }
                        
                        if (i > 0) {
                            up = mat[i -1, j];
                            Console.WriteLine($"Up: {up}");
                        }

                        if (j < n - 1){
                            rigth = mat[i, j+1];
                            Console.WriteLine($"Right: {rigth}");
                        }

                        if (j < m - 1) {
                            down = mat[i + 1, j];
                            Console.WriteLine($"Down: {down}");
                        }  

                    }

                }
            }

        }
    }
}