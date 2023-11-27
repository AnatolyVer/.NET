namespace Task_6    
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            short n;
            try
            {
                Console.WriteLine("Введите нечетный размер массива n * n");
                n = short.Parse(Console.ReadLine()!);
                if (n <= 0) throw new Exception("Неверный размер массива");
                if (n % 2 == 0) throw new Exception("С таким массивом нельзя выполнить это задание");
                int[,] matrix = new int[n, n];
                char direction = 'L';
                int num = 1;
                int times = 1; 
                int row = n / 2; 
                int col = n / 2;
                
                matrix[row, col] = num++;
                
                while (num <= n * n)
                {
                    if (times > n - 1) times = n - 1;
                    switch (direction)
                    {
                        case 'L':
                            for (int k = 0; k < times; k++)
                            {
                                matrix[row, --col] = num++;
                            }
                            direction = 'D';
                            break;
                        case 'D':
                            for (int k = 0; k < times; k++)
                            {
                                matrix[++row, col] = num++;
                            }
                            times++;
                            direction = 'R';
                            break;
                        case 'R':
                            for (int k = 0; k < times; k++)
                            {
                                matrix[row, ++col] = num++;
                            }
                            direction = 'U'; break;
                        case 'U': 
                            for (int k = 0; k < times; k++)
                            {
                                matrix[--row, col] = num++;
                            }
                            times++;
                            direction = 'L';
                            break;
                    }
                }
                            
                Console.WriteLine();
                for (int g = 0; g < n; g++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[g, j] + "\t");
                    }
                    Console.WriteLine();
                }                            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nНажмите любую кнопку, что бы продолжить");
                Console.ReadKey(true); 
            }
        }
    }
}