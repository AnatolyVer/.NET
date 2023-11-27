namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            List<Reader> readers = new List<Reader>();

            Random rand = new Random();
            
            for (int i = 0; i < 50; i++)
            {
                int nextReader = rand.Next(0, 3);
                Reader reader = new EBook();
                switch (nextReader)
                {
                    case 0:
                        reader = new PaperBook();
                        break;
                    case 1:
                        reader = new EBook();
                        break;
                    case 2:
                        reader = new Magazine();
                        break;
                    case 3:
                        reader = new Newspaper();
                        break;
                }
                
                readers.Add(reader);
            }
            
            Console.WriteLine("Поиск по названию:\n");
            string authorToSearch = readers[0].Name;
            foreach (var book in readers)
                if (book.Name == authorToSearch) book.show();
           
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
            Console.Clear();
            
            Console.WriteLine("Поиск по издательству:\n");
            string publisherToSearch = readers[0].Publisher;
            foreach (var book in readers)
                if (book.Publisher == publisherToSearch) book.show();
            
            Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
            Console.Clear();
            
            ushort year = 2000;
            Console.WriteLine($"Книги, выпущенные после {year}г.:\n");
            foreach (var book in readers)
                if (book.Year > year) book.show();
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}