using Microsoft.VisualBasic;

namespace Task_4;

public class Book
{
    private string 
        author, 
        name,
        publisher;

    private bool opened = false;
    private ushort currentPage = 1;
    
    private ushort
        year,
        pages;

    private Covering covering;
    
    public Book(string author, string name, string publisher, ushort year, ushort pages)
    {
        this.covering = new Covering();
        this.author = author;
        this.name = name;
        this.publisher =  publisher;
        this.year = year;
        this.pages = pages;
    }
    
    public string Author{get { return author;} set { author = value;}}
    public string Name{get { return name;} set { name = value;}}
    public string Publisher{get { return publisher;} set { publisher = value;}}

    public ushort Year{get { return year;} set { year = value;}}
    public ushort Pages{get { return pages;} set { pages = value;}}
    
    class Covering
    {
        private string type;
        private ushort scratches;

        public ushort Scratches
        {
            get => scratches;
            set => scratches = value;
        }
        
        public string Type
        {
            get => type;
            set => type = value;
        }

        public Covering()
        {
            Random rand = new Random();
            type = bookCoverTypes[rand.Next(0, bookCoverTypes.Count - 1)];
            scratches = 0;
        }

        private void Scratch()
        {
            Random rand = new Random();
            ushort scratches = (ushort)rand.Next(0, 4);
            Console.WriteLine($"Книга поцарапана {this.scratches} раз");
        } 
        
        private List<string> bookCoverTypes = new List<string>
        {
            "Мягкая обложка",
            "Твердая обложка",
            "Кожаная обложка"
        };
    }
    
    public void Open()
    {
        if (opened)
        {
            Console.WriteLine("Книга уже открыта");
        }
        else
        {
            Console.WriteLine("Книга открылась");
            opened = true;
        }
    }

    public void Close()
    {
        if (opened)
        {
            Console.WriteLine("Книга закрылась");
            opened = false;
        }
        else
        {
            Console.WriteLine("Книга уже закрыта");
        }
    }

    public void Read()
    {
        if (opened)
        {
            if (currentPage == 1)
            {
                Console.WriteLine("Начинаем читать книгу сначала...");
            }
            else
            {
                Console.WriteLine("Продолжаем читать книгу....\n");
            }
            Random rand = new Random();
            ushort readPages = (ushort)rand.Next(1, 20);
            currentPage += readPages;
            if (currentPage >= pages)
            {
                Console.WriteLine($"Книга дочитана до конца");
                currentPage = 1;
            }
            else
            {
                Console.WriteLine($"Прочитано {readPages} страниц. Текущая страница: {currentPage}");
            }
        }
        else
        {
            Console.WriteLine("Нельзя читать закрытую книгу");
        }
    }
    
    public void show()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Издание: {publisher}, {year}г.");
        Console.WriteLine($"{pages} страниц");
        Console.WriteLine($"Тип обкладинки: {covering.Type}");
        Console.WriteLine($"Кількість пошкоджень: {covering.Scratches}");
        Console.WriteLine($"---------------------------------");
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
    

    