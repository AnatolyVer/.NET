namespace Task_2;

public class Magazine : Reader
{

    protected string type;
    
    public Magazine(): base()
    {
        Random rand = new Random();

        type = types[rand.Next(0, types.Count - 1)];
    }
    
    public override void Open()
    {
        if (opened) Console.WriteLine("Журнал уже открыт");
        else
        {
            Console.WriteLine("Журнал открылся");
            opened = true;
        }
    }
    
    public override void Close()
    {
        if (opened)
        {
            Console.WriteLine("Журнал закрылся");
            opened = false;
        }
        else Console.WriteLine("Журнал уже закрыт");
    }
    
    public override void Read()
    {
        if (opened)
        {
            if (currentPage == 1)
            {
                Console.WriteLine("Начинаем читать журнал сначала...");
            }
            else
            {
                Console.WriteLine("Продолжаем читать журнал....\n");
            }
            Random rand = new Random();
            ushort readPages = (ushort)rand.Next(1, 20);
            currentPage += readPages;
            if (currentPage >= pages)
            {
                Console.WriteLine($"Журнал дочитан до конца");
                currentPage = 1;
            }
            else
            {
                Console.WriteLine($"Прочитано {readPages} страниц. Текущая страница: {currentPage}");
            }
        }
        else
        {
            Console.WriteLine("Нельзя читать закрытую журнал");
        }
    }
    
    public override void show()
    {
        Console.WriteLine("Тип: Журнал");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Тип: {type}");
        Console.WriteLine($"Издание: {publisher}, {year}г.");
        Console.WriteLine($"{pages} страниц");
        Console.WriteLine($"---------------------------------");
    }
    
    
    List<string> types = new List<string>
    {
        "Научный журнал",
        "Искусствоведческий журнал",
        "Модный журнал",
        "Журнал о здоровье и фитнесе",
        "Туристический журнал",
        "Кулинарный журнал"
    };
}