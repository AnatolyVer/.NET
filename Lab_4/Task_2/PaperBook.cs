namespace Task_2;

public class PaperBook : Book
{

    private string coverType, paperType;
    public string CoverType { get { return coverType; } set { coverType = value; } }
    public string PaperType { get { return paperType; } set { paperType = value; } }

    public PaperBook() : base()
    {
        Random rand = new Random();
        coverType = bookCoverTypes[rand.Next(0, bookCoverTypes.Count - 1)];
        paperType = bookPaperTypes[rand.Next(0, bookPaperTypes.Count - 1)];
    }
    
    public override void show()
    {
        Console.WriteLine("Тип: Книга");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Тип обложки: {coverType}");
        Console.WriteLine($"Тип бумаги: {paperType}");
        Console.WriteLine($"Издание: {publisher}, {year}г.");
        Console.WriteLine($"{pages} страниц");
        Console.WriteLine($"---------------------------------");
    }

   public override void Open()
    {
        if (opened) Console.WriteLine("Книга уже открыта");
        else
        {
            Console.WriteLine("Книга открылась");
            opened = true;
        }
    }

    public override void Close()
    {
        if (opened)
        {
            Console.WriteLine("Книга закрыта");
            opened = false;
        }
        else Console.WriteLine("Книга уже закрылась");
    }

    public override void Read()
    {
        if (opened)
        {
            if (currentPage == 1) Console.WriteLine("Начинаем читать книгу сначала...");
            else Console.WriteLine("Продолжаем читать книгу....");
            
            Random rand = new Random();
            
            ushort readPages = (ushort)rand.Next(1, 20);

            ushort chargeDifference = (ushort)(readPages / 5);
           
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

    private List<string> bookCoverTypes = new List<string>
    {
        "Мягкая обложка",
        "Твердая обложка",
        "Кожаная обложка"
    };
    
    private List<string> bookPaperTypes = new List<string>
    {
        "Матовая",
        "Глянцевая",
        "Пергаментовая"
    };
}