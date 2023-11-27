namespace Task_1
{
    class Program
    {
        static List<string> authors = new List<string> 
        {
                "Джейн Остин",
                "Федор Достоевский",
                "Эрнест Хемингуэй",
                "Агата Кристи",
                "Джордж Оруэлл",
                "Луиза Мэй Олкотт",
                "Габриэль Гарсия Маркес",
                "Джоан Роулинг",
                "Толкин",
                "Джон Грин"
            };            
                
        static List<string> names = new List<string> 
        {
                "Загадки прошлого",
                "Путешествие в неизведанное",
                "Ловушка времени",
                "Скрытые истины",
                "Следы загадочных событий",
                "Подземные миры",
                "В поисках потерянных артефактов",
                "Приключения в чужих мирах",
                "Симфония космоса",
                "Секреты магии и мистицизма",
                "Исчезновение на горизонте",
                "Под покровом ночи",
                "Путь к успеху",
                "Светлая сторона тьмы",
                "Истории из прошлого",
                "Часы судьбы",
                "Запретные знания",
                "Сокровища пиратов",
                "Поднимая занавес",
                "Путь к сердцу джунглей",
                "Секреты забытых храмов",
                "Легенды и мифы",
                "Смерть в тени",
                "В поисках истины"
            };            
                                
        static List<string> publishers = new List<string>
        {
                "Издательство Альфа",
                "Издательство Бета",
                "Издательство Гамма",
                "Издательство Дельта",
                "Издательство Эпсилон",
                "Издательство Зета",
                "Издательство Эта",
                "Издательство Тета",
                "Издательство Иота",
                "Издательство Каппа",
                "Издательство Лямбда",
                "Издательство Мю",
                "Издательство Кси",
                "Издательство Омикрон",
                "Издательство Пи",
                "Издательство Ро",
                "Издательство Сигма",
                "Издательство Тау",
                "Издательство Упсилон",
                "Издательство Фи",
                "Издательство Хи",
                "Издательство Пси",
                "Издательство Омега"
        };
        
        private static List<Book> searchByAuthor(List<Book> books, string authorToSearch)
        {
            List<Book> result = new List<Book>();
            foreach (var book in books)
                if (book.Author == authorToSearch) result.Add(book);

            return result;
        }        
        
        private static List<Book> searchByPublisher(List<Book> books, string publisherToSearch)
        {
            List<Book> result = new List<Book>();

            foreach (var book in books)
                if (book.Publisher == publisherToSearch) result.Add(book);

            return result;
        }    
        
        private static List<Book> searchAfterYear(List<Book> books, ushort year)
        {
            List<Book> result = new List<Book>();

            foreach (var book in books)
                if (book.Year == year) result.Add(book);

            return result;
        }

        private static void deleteBooks(List<Book> books, List<Book> booksToDelete)
        {
            Console.WriteLine($"Удалено {booksToDelete.Count} книг\n");
            foreach (var book in booksToDelete)
                books.Remove(book);
        }
        
        private static void printBooks(List<Book> books)
        {
            Console.WriteLine($"Книг: {books.Count}\n");
            foreach (var book in books)
                book.show();
            
            Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
            Console.Clear();
        }

        private static void changeBookByAuthor(List<Book> books, string author)
        {
            List<Book> foundBooks = searchByAuthor(books, author);
            Console.WriteLine($"У книг с автором {author} изменить:");
            Console.WriteLine("1. Название");
            Console.WriteLine("2. Автор");
            Console.WriteLine("3. Издательство");
            Console.WriteLine("4. Год");
            Console.WriteLine("5. Страницы");
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Введите новое значение: ");
            bool success;
            switch (key.KeyChar)
            {
                case '1':
                    var newName = Console.ReadLine()!;
                    foreach (var book in foundBooks)
                    {
                        books[books.IndexOf(book)].Name = newName;
                    } 
                    break;
                case '2':
                    var newAuthor = Console.ReadLine()!;
                    foreach (var book in foundBooks)
                    {
                        books[books.IndexOf(book)].Author = author;
                    } 
                    break;
                case '3':
                    var newPublisher = Console.ReadLine()!;
                    foreach (var book in foundBooks)
                    {
                        books[books.IndexOf(book)].Publisher = newPublisher;
                    } 
                    break;
                case '4':
                    ushort newYear;
                    success = ushort.TryParse(Console.ReadLine()!, out newYear);
                    if (success)
                    {
                        foreach (var book in foundBooks)
                        {
                            books[books.IndexOf(book)].Year = newYear;
                        } 
                    }
                    else
                    {
                        Console.WriteLine("Отмена. Неверные данные");
                    }
                    break;
                case '5':
                    ushort page;
                    success = ushort.TryParse(Console.ReadLine()!, out page);
                    if (success)
                    {
                        foreach (var book in foundBooks)
                        {
                            books[books.IndexOf(book)].Pages = page;
                        } 
                    }
                    else
                    {
                        Console.WriteLine("Отмена. Неверные данные");
                    }
                    break;
                default:
                    Console.WriteLine("Неверный пункт меню");
                    break;
            }
            Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
            Console.Clear();
        }
        
        public static void Main(string[] args)
        {
            Console.Clear();

            List<Book> books = new List<Book>();
            Random rand = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                string author = authors[rand.Next(0, authors.Count - 1)];
                string name = names[rand.Next(0, names.Count - 1)];
                string publisher =  publishers[rand.Next(0, publishers.Count - 1)];
                ushort year = (ushort)rand.Next(1500, 2023);
                ushort pages = (ushort)rand.Next(10, 400);
                books.Add(new Book(author, name, publisher, year, pages));
            }
            
            printBooks(books);
            
            string authorToWork = books[1].Author;
            changeBookByAuthor(books, authorToWork);
            printBooks(searchByAuthor(books, authorToWork));
            deleteBooks(books, (searchByAuthor(books, authorToWork)));
            Console.WriteLine($"Поиск по автору: {authorToWork}\n");
            printBooks(searchByAuthor(books, authorToWork));
        }
    }
}