namespace Task_3
{
    class Program
    {
        private static void Square(List<SqrMatrix> list)
        {
            foreach (var matrix in list)
                matrix.Square();
        }
        
        public static void Main(string[] args)
        {
            Console.Clear();

            SqrMatrix mat1 = new SqrMatrix(3);
            SqrMatrix mat2 = new SqrMatrix(mat1);
            
            mat1.Show();

            mat2.Show();
            
            (mat1 * mat2).Show();
            
            mat1.Square();
            
            mat1.Show();
            
            List<SqrMatrix> list = new List<SqrMatrix>();

            for (int i = 0; i < 3; i++)
                list.Add(new SqrMatrix(3)); 
            
            for (int i = 0; i < 3; i++)
                list[i].Show();
            
            Square(list);
            
            for (int i = 0; i < 3; i++)
                list[i].Show();
            
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить");
            Console.ReadKey(true);
        }
    }
}