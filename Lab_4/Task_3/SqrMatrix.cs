namespace Task_3;


public class SqrMatrix
{
    private double[,] data;
    public int Size { get; private set; }

    public SqrMatrix(int size)
    {
        Random rand = new Random();
        Size = size;
        data = new double[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                data[i, j] = rand.Next(-50, 50);
            }
        }
    }

    public SqrMatrix(SqrMatrix other)
    {
        Size = other.Size;
        data = new double[Size, Size];
        Array.Copy(other.data, data, Size * Size);
    }

    public void Copy(SqrMatrix other)
    {
        Size = other.Size;
        data = new double[Size, Size];
        Array.Copy(other.data, data, Size * Size);
    }
    
    public double this[int row, int col]
    {
        get { return data[row, col]; }
        set { data[row, col] = value; }
    }

    public static SqrMatrix operator +(SqrMatrix matrix1, SqrMatrix matrix2)
    {
        if (matrix1.Size != matrix2.Size)
            throw new ArgumentException("Розмірності матриць повинні співпадати.");

        SqrMatrix result = new SqrMatrix(matrix1.Size);
        for (int i = 0; i < matrix1.Size; i++)
        {
            for (int j = 0; j < matrix1.Size; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    public static SqrMatrix operator -(SqrMatrix matrix1, SqrMatrix matrix2)
    {
        if (matrix1.Size != matrix2.Size)
            throw new ArgumentException("Розмірності матриць повинні співпадати.");

        SqrMatrix result = new SqrMatrix(matrix1.Size);
        for (int i = 0; i < matrix1.Size; i++)
        {
            for (int j = 0; j < matrix1.Size; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    public static SqrMatrix operator *(SqrMatrix matrix1, SqrMatrix matrix2)
    {
        if (matrix1.Size != matrix2.Size)
            throw new ArgumentException("Розмірності матриць повинні співпадати.");

        SqrMatrix result = new SqrMatrix(matrix1.Size);

        for (var i = 0; i < matrix1.Size; i++)
        {
            for (var j = 0; j < matrix1.Size; j++)
            {
                for (var k = 0; k < matrix1.Size; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    public double Norm()
    {
        double norm = 0.0;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                norm += Math.Abs(data[i, j]);
            }
        }
        return norm;
    }
    
    public void Square()
    {
        this.data = (this * this).data;
    }
    
    public void Show()
    {
        Console.WriteLine();
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.Write($"{data[i, j],  7}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
