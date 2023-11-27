namespace Task_8
{
    class Program
    {

        private unsafe static string task7(string str)
        {
            fixed (char* ptr = str)
            {
                char* i = ptr;
                char* endPtr = ptr + str.Length;

                while (i < endPtr)
                {
                    if (*i == ' ')
                    {
                        char* current = i;
                        i = endPtr;
                        while (i > current)
                        {
                            *i = *(i - 1);
                            i--;
                        }
                        i = current;
                        *i = ' ';
                        i++;
                        endPtr++;
                    }
                    i++;
                }
                i = ptr;

                char[] result = new char[endPtr - ptr];
                while (i < endPtr)
                {
                    result[result.Length - (endPtr - i)] = *i++;
                }
                return new string(result);
            }
        }

        private unsafe static int task8(string str)
        {
            string chars = "аоїуюяиєАОЇУЮЯИЄ";

            short counter = 0;
            
            fixed (char* ptr = str)
            {
                char* i = ptr;
                char* endPtr = ptr + str.Length;

                while (i < endPtr)
                {
                    if (chars.Contains(*i) && *(i - 1) == ' ') counter++;
                    i++;
                }
            }
            return counter;
        }
        
        public unsafe static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Введите вашу строку:");
            string str = Console.ReadLine()!;
            
            string filePath = "binary.bin";

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(task7(str)); 
                writer.Write(task8(str));
            }
            
            Console.WriteLine("Чтение из бинарного файла");
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                Console.WriteLine($"Task 7:\n{reader.ReadString()}");
                Console.WriteLine($"Task 8:\n{reader.ReadInt32()}");
            }
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
        }
    }
}