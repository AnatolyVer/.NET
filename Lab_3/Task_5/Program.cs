namespace Task_5
{
    class Program
    {
        public unsafe static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Введите вашу строку:");
            string str = Console.ReadLine()!;
            
            string chars = "аоїіуюяиєеАОЇІУЮЯИЄЕ";

            short counter = 0;
            
            fixed (char* ptr = str)
            {
                char* i = ptr;
                char* endPtr = ptr + str.Length;

                while (i < endPtr)
                {
                    if (chars.Contains(*i) && (*(i - 1) == ' ' || i == ptr)) counter++;
                    i++;
                }
            }

            Console.WriteLine($"Количество слов, которые начинаются на гласную украинскую букву: {counter}");
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
        }
    }
}