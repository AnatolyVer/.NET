namespace Task_2
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            try
            {
                short counter = 0;
                short size;

                Console.WriteLine("Введите размер массива");
                size =  short.Parse(Console.ReadLine()!);
                if (size <= 0)
                {
                    throw new Exception("\nНеверный размер массива");
                }
                
                int[] array = new int[size];
                Random rand = new Random();

                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next(-50, 50);
                }

                short c = 0;

                foreach (var num in array)
                {
                    Console.Write($"{num, 5}");
                    c++;
                    if (c == 10)
                    {
                        c = 0;
                        Console.WriteLine();
                    }
                }
                
                for (int i = 0; i < size - 1; i++)
                {
                    if ((array[i] >= 0 && array[i+1] < 0) || (array[i] < 0 && array[i+1]  >= 0))
                    {
                        counter++;
                    }
                }
            
                Console.WriteLine($"\nКоличество пар соседних элементов, которые имеют противоположные знаки: {counter}");
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