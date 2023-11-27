using Task_2;

public abstract class Book : Reader
{
    protected string author; 
    
    public string Author{get { return author;} set { author = value;}}
    
    public Book(): base()
    {
        Random rand = new Random();

        author = authors[rand.Next(0, authors.Count - 1)];
    }

    public override abstract void Read();
    public override abstract void Open();
    public override abstract void Close();

    public override void show()
    {
        Console.WriteLine("Тип: Книга");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Издание: {publisher}, {year}г.");
        Console.WriteLine($"{pages} страниц");
        Console.WriteLine($"---------------------------------");
    }
    
    List<string> authors = new List<string>
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
}