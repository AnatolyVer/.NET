namespace Task_2;

public class Newspaper : Reader
{
    private string title, editor;
    public string Title { get { return title; } set { title = value; } }
    public string Editor { get { return editor; } set { editor = value; } }

    public Newspaper(): base()
    {
        Random rand = new Random();

        editor = editors[rand.Next(0, editors.Count - 1)];
        title = titles[rand.Next(0, titles.Count - 1)];
    }
    
    public override void Open()
    {
        if (opened) Console.WriteLine("Газета уже открыта");
        else
        {
            Console.WriteLine("Газета открылась");
            opened = true;
        }
    }
    
    public override void Close()
    {
        if (opened)
        {
            Console.WriteLine("Газета закрылась");
            opened = false;
        }
        else Console.WriteLine("Газета уже закрыта");
    }
    
    public override void Read()
    {
        if (opened)
        {
            if (currentPage == 1)
            {
                Console.WriteLine("Начинаем читать газету сначала...");
            }
            else
            {
                Console.WriteLine("Продолжаем читать газету....\n");
            }
            Random rand = new Random();
            ushort readPages = (ushort)rand.Next(1, 20);
            currentPage += readPages;
            if (currentPage >= pages)
            {
                Console.WriteLine($"Газета дочитана до конца");
                currentPage = 1;
            }
            else
            {
                Console.WriteLine($"Прочитано {readPages} страниц. Текущая страница: {currentPage}");
            }
        }
        else
        {
            Console.WriteLine("Нельзя читать закрытую газету");
        }
    }
    
    public override void show()
    {
        Console.WriteLine("Тип: Газета");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Заголовок: {title}");
        Console.WriteLine($"Редактор: {editor}");
        Console.WriteLine($"Издание: {publisher}, {year}г.");
        Console.WriteLine($"{pages} страниц");
        Console.WriteLine($"---------------------------------");
    }
    
    List<string> editors = new List<string> {
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
    List<string> titles = new List<string> {
        "Наука и технологии",
        "Здоровье и фитнес",
        "Путешествия и приключения",
        "Искусство и культура",
        "Мир моды",
        "Спортивные новости",
        "Бизнес и финансы",
        "Еда и кулинария",
        "Развлечения и шоу-бизнес",
        "Образование и наука"
    };
}