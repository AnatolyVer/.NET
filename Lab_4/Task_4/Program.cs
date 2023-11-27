namespace Task_4
{
    class Program
    {
        public static void Main(string[] args)
        {

            Bookshelf bookshelf = new Bookshelf();
            
            bookshelf.Show();
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}