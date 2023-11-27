namespace Task_4
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            try
            {
                short size;
                short counter = 0;
            
                Console.WriteLine("Введите размер массива");
                size =  short.Parse(Console.ReadLine()!);
                if (size <= 0) throw new Exception("\nНеверный размер массива");
                
                List<int> array = new List<int>(size);
                Random rand = new Random();

                for (int i = 0; i < size; i++) array.Add(rand.Next(-50, 50));
                
                short c = 0;
                
                for (int i = 0; i < size - 1; i++)
                {
                    bool pair = false;
                    if ((array[i] >= 0 && array[i+1] < 0) || (array[i] < 0 && array[i+1]  >= 0))
                    {
                        counter++;
                        pair = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"{array[i], 5}");
                    c++;
                    if (c == 10)
                    {
                        c = 0;
                        Console.WriteLine();
                    }
                    if (!pair) Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine($"{array[array.Count - 1], 5}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nКоличество пар соседних элементов, которые имеют противоположные знаки: {counter}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Нажмите любую кнопку, что бы продолжить");
                Console.ReadKey(true);
            }    
        }
    }
}