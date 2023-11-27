namespace Task_2;

public class EBook : Book
{
    protected ushort charge = 100;
    public ushort Charge { get { return charge; } set { charge = value; } }

    private string manufacturer;
    public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }

    public EBook() : base()
    {
        Random rand = new Random();
        manufacturer = ebookManufacturers[rand.Next(0, ebookManufacturers.Count - 1)];
    }

    public void Charging()
    {
        Console.WriteLine("Начинаем зарядку.");
        charge = 100;
        Console.WriteLine("Зарядка окончена.");
    }
    
    public override void Open()
    {
        if (opened) Console.WriteLine("Книга уже включена");
        else
        {
            if (charge == 1)
            {
                Console.WriteLine($"Книга села. Поставьте ее на зарядку");
                return;
            }
            
            Console.WriteLine("Книга включилась");
            opened = true;
            charge--;
        }
    }

    public override void Close()
    {
        if (opened)
        {
            Console.WriteLine("Книга выключилась");
            opened = false;
        }
        else Console.WriteLine("Книга уже выключена");
    }

    public override void Read()
    {
        if (opened)
        {
            charge--;
            if (charge == 0)
            {
                Console.WriteLine($"Книга села. Поставьте ее на зарядку");
                opened = false;
                return;
            }
            
            if (currentPage == 1) Console.WriteLine("Начинаем читать книгу сначала...");
            else Console.WriteLine("Продолжаем читать книгу....");
            
            Random rand = new Random();
            
            ushort readPages = (ushort)rand.Next(1, 20);

            ushort chargeDifference = (ushort)(readPages / 5);
            if (charge - chargeDifference <= 0)
            {
                while (charge - chargeDifference < 0)
                {
                    chargeDifference++;
                    readPages -= 5;
                }
                
                currentPage += readPages;
                charge = 0;
                Console.WriteLine($"Книга села. Поставьте ее на зарядку");
                Console.WriteLine($"Прочитано {readPages} страниц. Текущая страница: {currentPage}");
                opened = false;
            }
            else
            {
                charge -= chargeDifference;
                currentPage += readPages;
                if (currentPage >= pages)
                {
                    Console.WriteLine($"Книга дочитана до конца");
                    currentPage = 1;
                }
                else
                {
                    Console.WriteLine($"Прочитано {readPages} страниц. Текущая страница: {currentPage}");
                    Console.WriteLine($"Заряд: {charge}%");
                }
            }
        }
        else
        {
            Console.WriteLine("Нельзя читать закрытую книгу");
        }
    }

    public override void show()
    {
        Console.WriteLine("Тип: Электронная Книга");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Издание: {publisher}, {year}г.");
        Console.WriteLine($"Производитель: {manufacturer}");
        Console.WriteLine($"{pages} страниц");
        Console.WriteLine($"Заряд: {charge}%");
        Console.WriteLine($"---------------------------------");
    }
    
    
    List<string> ebookManufacturers = new List<string>
    {
        "Amazon Kindle",
        "Apple (iPad)",
        "Barnes & Noble (Nook)",
        "Kobo",
        "Sony",
        "Google Play Books",
        "PocketBook",
        "Bookeen",
        "Onyx Boox",
        "Icarus",
        "Tolino"
    };
}