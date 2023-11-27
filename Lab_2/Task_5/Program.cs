namespace Task_5    
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int n = 9;
            int[,] matrix = new int[n, n];

            char direction = 'L';
            int num = 1;
            int times = 1;
            int row = n / 2;    
            int col = n / 2;

            matrix[row, col] = num++;

            while (num <= 81)
            {
                if (times > 8) times = 8;
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
                        direction = 'U';
                        break;
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
            
            Console.WriteLine("\n\n");
            for (int g = 0; g < n; g++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[g, j] + "\t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\nНажмите любую кнопку, что бы продолжить");
            Console.ReadKey(true); 
        }
    }
}