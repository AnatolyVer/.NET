namespace Task_4;

public class Bookshelf
{
    private List<Book> books;
    
    public Bookshelf(ushort count = 7)
    {
        books = new List<Book>();
        
        Random rand = new Random();

        for (int i = 0; i < count; i++)
        {
            string author = authors[rand.Next(0, authors.Count - 1)];
            string name = names[rand.Next(0, names.Count - 1)];
            string publisher =  publishers[rand.Next(0, publishers.Count - 1)];
            ushort year = (ushort)rand.Next(1500, 2023);
            ushort pages = (ushort)rand.Next(10, 400);
            books.Add(new Book(author, name, publisher, year, pages));
        }
    }

    public Book this[int i]
    {
        get { return books[i]; }
        set { books[i] = value; }
    }
    
    public void searchByAuthor(string authorToSearch = "Джордж Оруэлл")
    {
        Console.WriteLine("Поиск по автору:\n");
        bool entered = false;
        foreach (var book in books)
        {
            if (book.Author == authorToSearch) 
            {
                entered = true;
                book.show();
            }
        }
        if (!entered)
        {
            Console.WriteLine("Ничего не найдено");
        }
        Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
        Console.ReadKey(true);
    }

    public void searchByPublisher(string publisherToSearch = "Издательство Альфа")
    {
        Console.WriteLine("\nПоиск по издательству:\n");
        bool entered = false;
        foreach (var book in books)
        {
            if (book.Publisher == publisherToSearch)
            {
                entered = true;
                book.show();
            }
        }
        if (!entered)
        {
            Console.WriteLine("Ничего не найдено");
        }
        Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
        Console.ReadKey(true);
    }

    public void searchAfterYear(ushort year = 2000)
    {
        Console.WriteLine($"\nКниги, выпущенные после {year}г.:\n");
        
        bool entered = false;
        foreach (var book in books)
        {
            if (book.Year > year)
            {
                entered = true;
                book.show();
            }
        }
        if (!entered)
        {
            Console.WriteLine("Ничего не найдено");
        }
        Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
        Console.ReadKey(true);
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }
    
    public void AddBook()
    {
        Random rand = new Random();

        string author = authors[rand.Next(0, authors.Count - 1)];
        string name = names[rand.Next(0, names.Count - 1)];
        string publisher =  publishers[rand.Next(0, publishers.Count - 1)];
        ushort year = (ushort)rand.Next(1500, 2023);
        ushort pages = (ushort)rand.Next(10, 400);
        books.Add(new Book(author, name, publisher, year, pages));
    }

    public void RemoveBookAfterYear(ushort year = 2000)
    {
        foreach (var book in books)
        {
            if (book.Year > year)
            {
                books.Remove(book);
            }  
        }
    }
    
    public void RemoveBookByPublisher(string publisherToDelete = "Издательство Альфа")
    {
        foreach (var book in books)
        {
            if (book.Publisher == publisherToDelete)
            {
                books.Remove(book);
            }  
        }
    }
    
    public void RemoveBookByAuthor(string authorToDelete = "Джордж Оруэлл")
    {
        foreach (var book in books)
        {
            if (book.Author == authorToDelete)
            {
                books.Remove(book);
            }  
        }
    }
    
    public void RemoveBook(ushort at)
    {
        books.RemoveAt(at);
    }
    
    public void RemoveBook()
    {
        books.RemoveAt(books.Count - 1);
    }
    
    public void Show()
    {
        foreach (var book in books)
            book.show();
    }
    
    
    
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
}