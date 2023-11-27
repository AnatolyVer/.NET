namespace Task_1
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Random rand = new Random();
            
            int[] array = new int[200];

            for (int i = 0; i < 200; i++)
            {
                array[i] = rand.Next(-50, 50);
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{array[10*i + j]}\t");
                }
                Console.WriteLine("\n");
            }

            short counter = 0;
            
            for (int i = 0; i < 199; i++)
            {
                if ((array[i] >= 0 && array[i+1] < 0) || (array[i] < 0 && array[i+1] >= 0))
                {
                    counter++;  
                }
            }
            
            Console.WriteLine($"Количество пар соседних элементов, которые имеют противоположные знаки: {counter}");
            
            Console.WriteLine("\nНажмите любую кнопку, что бы продолжить");
            Console.ReadKey(true); 
        }
    }
}