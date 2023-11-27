namespace Task_2
{
    class Program
    {
        public unsafe static void Main(string[] args)
        {
            Console.Clear();
            
            Console.Write("Введите строку: ");
            string str = Console.ReadLine()!;
            
            fixed (char* ptr = str)
            {
                char* endPtr = ptr + str.Length - 1;
                
                while (endPtr >= ptr)
                    Console.Write(*endPtr--);
            }
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
        }
    }
}