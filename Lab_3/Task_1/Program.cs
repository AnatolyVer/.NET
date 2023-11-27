namespace Task_1
{
    class Program
    {
        private unsafe static void compare(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Строки неравны");
                return;
            }
            
            fixed (char* ptr1 = str1)
            {
                fixed (char* ptr2 = str2)
                {
                    char* temp_ptr1 = ptr1, temp_ptr2 = ptr2;
                    char* endPtr1 = ptr1 + str1.Length, endPtr2 = ptr2 + str2.Length;
                    while (temp_ptr1 < endPtr1 && temp_ptr2 < endPtr2)
                    {

                        if ((*temp_ptr1).ToString().ToLower() != (*temp_ptr2).ToString().ToLower())
                        {
                            Console.WriteLine("Строки неравны");
                            return;
                        }
                        
                        temp_ptr1++;
                        temp_ptr2++;
                    }
                    Console.WriteLine("Строки равны");
                    return;
                }
            }
        }
        
        public static void Main(string[] args)
        {
            Console.Clear();

            string str1, str2;
            
            Console.WriteLine("Введите две строки");

            str1 = Console.ReadLine()!;
            str2 = Console.ReadLine()!;
            
            compare(str1, str2);
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
        }
    }
}