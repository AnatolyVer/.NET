namespace Task_1
{
    class Program
    {
        private unsafe static string compare(string str1, string str2)
        {
            if (str1.Length != str2.Length) return "Строки неравны";
            unsafe
            {
                fixed (char* ptr1 = str1)
                {
                    fixed (char* ptr2 = str2)
                    {
                        char* temp_ptr1 = ptr1, temp_ptr2 = ptr2;
                        char* endPtr1 = ptr1 + str1.Length, endPtr2 = ptr2 + str2.Length;
                        while (temp_ptr1 < endPtr1 && temp_ptr2 < endPtr2)
                        {
                            char temp1 = *temp_ptr1;
                            char temp2 = *temp_ptr2;

                            if ((*temp_ptr1).ToString().ToLower() != (*temp_ptr2).ToString().ToLower())  return "Строки неравны";
                            temp_ptr1++;
                            temp_ptr2++;
                        }
                        return "Строки равны";
                    }
                }
            }
        }
        
        private unsafe static string reverse(string str)
        {
            fixed (char* ptr = str)
            {
                var i = ptr;
                char* endPtr = ptr + str.Length;

                char[] result = new char[str.Length];

                while (endPtr > i)
                {
                    result[str.Length - (endPtr - i)] = *--endPtr;
                }
                
                return new string(result);
            }
        }

        private unsafe static string task3(string str)
        {
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

                if (counter_p > counter_r) return "Букв 'п' больше, чем букв 'р'";
                else if (counter_p < counter_r) return "Букв 'р' больше, чем букв 'п'";
                else return "Букв 'р' и 'п' одинаково";
            }
        }
        
        public static void Main(string[] args)
        {
            Console.Clear();
            
            string filePath = "LAB.txt";
            string fileResultPath = "RESULT.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string str1 = reader.ReadLine();
                    string str2 = reader.ReadLine();
                    string str3 = reader.ReadLine();
                    string str4 = reader.ReadLine();
                    
                    using (StreamWriter writer = new StreamWriter(fileResultPath))
                    
                    if (str1 != null && str2 != null && str3 != null && str4 != null)
                    {
                        writer.WriteLine("Task 1:");
                        writer.WriteLine(compare(str1, str2));
                        writer.WriteLine("Task 2:");
                        writer.WriteLine(reverse(str3));
                        writer.WriteLine("Task 3:");
                        writer.WriteLine(task3(str4));
                        Console.WriteLine("Проверьте файл " + fileResultPath);
                    }
                    else Console.WriteLine("Недостаточно строк в файле.");
                    Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey(true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey(true);
                throw;
            }
        }
        
    }
}