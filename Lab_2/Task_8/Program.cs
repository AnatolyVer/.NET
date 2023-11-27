namespace Task_8    
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

                Random rand = new Random();
                
                int[][] matrix = new int[n][];
                for (int i = 0; i < n; i++) matrix[i] = new int[n];
                
                char direction = 'L';
                int num = 1;
                int times = 1; 
                int row = n / 2; 
                int col = n / 2;
                
                matrix[row][col] = num++;
                
                while (num <= n * n)
                {
                    if (times > n - 1) times = n - 1;
                    switch (direction)
                    {
                        case 'L':
                            for (int k = 0; k < times; k++)
                            {
                                matrix[row][--col] = num++;
                            }
                            direction = 'D';
                            break;
                        case 'D':
                            for (int k = 0; k < times; k++)
                            {
                                matrix[++row][col] = num++;
                            }
                            times++;
                            direction = 'R';
                            break;
                        case 'R':
                            for (int k = 0; k < times; k++)
                            {
                                matrix[row][++col] = num++;
                            }
                            direction = 'U'; break;
                        case 'U': 
                            for (int k = 0; k < times; k++)
                            {
                                matrix[--row][col] = num++;
                            }
                            times++;
                            direction = 'L';
                            break;
                    }
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n");
                Console.WriteLine("╔" + new string('═', 5 * n + 1) + "╗");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("║ ");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{matrix[i][j], -5}");
                    }
                    Console.WriteLine("║");
                }
                Console.WriteLine("╚" + new string('═', 5 * n + 1) + "╝");                   
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\nНажмите любую кнопку, что бы продолжить");
                Console.ReadKey(true); 
            }
        }
    }
}