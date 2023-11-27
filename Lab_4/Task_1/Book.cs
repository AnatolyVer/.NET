using Microsoft.VisualBasic;

namespace Task_1;

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
    
    public Book(string author, string name, string publisher, ushort year, ushort pages)
    {
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
        Console.WriteLine($"---------------------------------");
    }
}