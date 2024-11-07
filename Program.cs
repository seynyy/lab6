namespace lab6;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //task1
        {
            static double Func1(double x, double y)
            {
                return x+Math.Sin(y)/(Math.Sin(x)+y);
            }
            
            double y = Func1(1, 4) + Func1(7, 5) + Func1(3, 2);
            Console.WriteLine("Значення функції: "+y);
        }
        
        //task2
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            
            static double A(double x, double c) => Math.Pow(Math.Abs(B(x)+c), 0.3d);

            static double B(double x) => Math.Sqrt(x);
            
            double y = A(x, c)*Math.Pow(Math.Sin(B(x)), 2)+B(x)*Math.Pow(Math.Cos(A(x, c)), 2);
            Console.WriteLine(y);
        }
        
        //task3
        {
            int[,] matrix = new int[4, 5];
            GenerateMatrix(ref matrix);
            WriteMatrix(matrix);
            (int column, int row) = ProcessMatrix(matrix);
            Console.WriteLine($"Max value position: {row}, {column}");

            static void GenerateMatrix(ref int[,] matrix)
            {
                Random random = new Random();
                
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(0, 100);
                    }
                    Console.Write("\n");
                }
            }
            
            static void WriteMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.Write("\n");
                }
            }

            static (int column, int row) ProcessMatrix(int[,] matrix)
            {
                int column = 0;
                int row = 0;
                double maxValue = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > maxValue)
                        {
                            maxValue = matrix[i, j];
                            column = j;
                            row = i;
                        }
                    }

                    Console.Write("\n");
                }

                return (column, row);
            }
        }
        
        //task4
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            static int Power(int m, int n)
            {
                if (n == 0)
                    return 1;
                return m * Power(m, n - 1);
            }
            
            Console.WriteLine(Power(m, n));
        }
    }
}