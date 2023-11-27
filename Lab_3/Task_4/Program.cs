namespace Task_3
{
    class Program
    {
        public unsafe static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Введите вашу строку:");
            string str = Console.ReadLine()!;

            fixed (char* ptr = str)
            {
                char* i = ptr;
                char* endPtr = ptr + str.Length;
                while (i < endPtr)
                {
                    if (*i == ' ')
                    {
                        char* current = i;
                        i = endPtr++;
                        while (i > current)
                        {
                            *i = *(i - 1);
                            i--;
                        }
                        *i++ = ' ';
                    }
                    i++;
                }
                i = ptr;
                while (i < endPtr)
                    Console.Write(*i++);
            }

            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
        }
    }
}