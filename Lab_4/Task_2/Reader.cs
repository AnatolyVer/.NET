namespace Task_2;

public abstract class Reader
{
    protected string publisher, name;
    protected ushort pages, year;

    protected bool opened = false;
    protected ushort currentPage = 1;
    
    public string Name{get { return name;} set { name = value;}}
    public string Publisher{get { return publisher;} set { publisher = value;}}
    public ushort Pages{get { return pages;} set { pages = value;}}
    public ushort Year{get { return year;} set { year = value;}}
    
    public Reader()
    {
        Random rand = new Random();

        name = names[rand.Next(0, names.Count - 1)];
        publisher =  publishers[rand.Next(0, publishers.Count - 1)];
        pages = (ushort)rand.Next(10, 400);
        year = (ushort)rand.Next(1500, 2023);
    }

    public abstract void show();
    public abstract void Open();
    public abstract void Close();
    public abstract void Read();

    
    List<string> names = new List<string>
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
                        
    List<string> publishers = new List<string>
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