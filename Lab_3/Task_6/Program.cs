namespace Task_5
{
    class Program
    {
        public unsafe static void Main(string[] args)
        {
            Console.Clear();

            string chars = " .,?:;";

            string vowel = "аоуияюЇєеэАОЇУЮЯИЄЕЭ"; 
            
            Console.WriteLine("Введите вашу строку:");
            string str = Console.ReadLine()!;
            
            short counter = 0;
            short max_vowel_counter = 0;
            short vowel_counter = 0;
            fixed (char* ptr = str)
            {
                char* i = ptr;
                char* endPtr = ptr + str.Length;

                char* start = ptr, end = ptr;

                //Deleting spaces
                while (i < endPtr)
                {
                    if (*i == ' ' && *(i+1) == ' ')
                    {
                        char* current = i;
                        while (i < endPtr)
                        {
                            *i = *(i + 1);
                            i++;
                        }
                        i = current;
                        endPtr--;
                    }
                    else i++;
                }

                i = ptr;
                
                //Calculating words
                bool isWord = false;
                char* temp_start = i, temp_end = i;

                while (i < endPtr)
                {
                    if (!chars.Contains(*i) && !isWord)
                    {
                        temp_start = i;
                        isWord = true;
                        counter++;
                    }
                    else if ((chars.Contains(*i) && !chars.Contains(*(i - 1))) || i+1 == endPtr)
                    {
                        temp_end = i;
                        isWord = false;
                        if (max_vowel_counter < vowel_counter)
                        {
                            max_vowel_counter = vowel_counter;
                            start = temp_start;
                            end = temp_end;
                        }
                        vowel_counter = 0;
                    } 

                    if (isWord && vowel.Contains(*i))
                        vowel_counter++;
                    
                    i++;
                }

                i = ptr;
                
                Console.WriteLine($"\nКоличество слов: {counter}");
                
                Console.Write("Слово с найбольшим количеством гласных букв: ");
                if (max_vowel_counter != 0)
                {
                    while (start <= end)
                        Console.Write(*start++);
                }
                
                Console.Write("\nСтрока без лишних пробелов: ");
                while (i < endPtr)
                    Console.Write(*i++);
            }
            
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
        }
    }
}