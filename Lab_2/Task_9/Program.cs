namespace Task_9    
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            short n = 0;
            Console.Write("Введите рамер n матрицы n * n: ");
            try
            {
                Random random = new Random();

                n = short.Parse(Console.ReadLine()!);
                if (n <= 0) throw new Exception("Неверный размер матрицы");
                
                int[,] matrix = new int[n, n];
                
                for (int i = 0; i < n; i++) 
                    for (int j = 0; j < n; j++)
                        matrix[i, j] = random.Next(-100, 100); 
                
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write($"{matrix[i, j],4} ");
                    Console.WriteLine();
                }
                
                int max_sum = Int32.MinValue;
                
                for (int i = 1; i < n; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < n - i; j++)
                    {
                        sum += matrix[i + j, j];
                    }
                    max_sum = Math.Max(max_sum, sum);
                }
                
                for (int i = 1; i < n; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < n - i; j++)
                    {
                        sum += matrix[j, j + i];
                    }
                    max_sum = Math.Max(max_sum, sum);
                }
                
                Console.WriteLine($"Max = {max_sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("\nНажмите любую кнопку, что бы продолжить"); 
                Console.ReadKey(true); 
            }
        }
    }
}