namespace Task_3
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
                var i = ptr;
                char* endPtr = ptr + str.Length;

                short counter_p = 0, counter_r = 0;
                
                while (i < endPtr) 
                {
                    if ((*i).ToString().ToLower().Equals("п")) counter_p++;
                    if ((*i).ToString().ToLower().Equals("р")) counter_r++;
                    i++;
                }

                if (counter_p > counter_r)  Console.WriteLine("Букв 'п' больше, чем букв 'р'");
                else if (counter_p < counter_r) Console.WriteLine("Букв 'р' больше, чем букв 'п'");
                else Console.WriteLine("Букв 'р' и 'п' одинаково");
            }
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
        }
    }
}