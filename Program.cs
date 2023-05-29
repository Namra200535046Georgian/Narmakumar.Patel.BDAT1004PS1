public class Program
{
    private static void Main(string[] args)
    {
        question_1();
        question_2();
        question_3();
        question_4();
        question_5();
    }
    // Question 1 - What data type is each of the following?
    public static void question_1()
    {
        Console.WriteLine("Q.1 Data Types \n");
        object[] objects = { 5, 5.0, 5>1, '5', 5 * 2, '5' * 2, '5' + '2', 5 / 2, 5 % 2, new int[] { 5, 2, 1 }, 5 == 3, Math.PI };
        foreach (var item in objects)
        {
            getDataType(item);
        }
    }
    //To get data type of object
    public static void getDataType(object o)
    {
        Console.WriteLine("\t"+o +" - "+ o.GetType().Name);
    }

    public static void question_2()
    {
        string s = "Supercalifragilisticexpialidocious";
        Console.WriteLine("\nQ.2 : Write (and evaluate) C# expressions");
        // Question 1
        Console.WriteLine("\n\tGiven String : " + s);
        // Question 2
        Console.WriteLine("\tA. Letters count : " + s.Length);
        Console.WriteLine("\tB. Does given string contain 'ice' as a substring? : "+ s.Contains("ice"));
        // Question 3
        string[] words = { "Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus", "Bababadalgharaghtakamminarronnkonn" };
        int maxLength = words.Max(x => x.Length);
        Console.WriteLine("\tC. Longest words amongst given three words are : "+String.Join(",",words.Select(x=> x).Where(x=>x.Length == maxLength)));
        // Question 4

        string[] wordArr = { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };
        Array.Sort(wordArr);
        Console.WriteLine("\tD. The First composer : " + wordArr[0]);
        Console.WriteLine("\tE. The Last composer : " + wordArr[wordArr.Length - 1 ]);
    }

    public static void question_3()
    {
        Console.WriteLine("\nQ.3 Implement function triangleArea(x,y,x)\n\tArea of triangle : "+triangleArea(2,2,2));
    }
    public static double triangleArea(double x, double y, double z)
    {
        double s = (x+y+z)/2;
        double area = Math.Sqrt((s * (s - x) * (s - y) * (s - z)));
        return area;
    }

    public static void question_4()
    {
        Console.WriteLine("\nQ.4 Write a program in C# Sharp to separate odd and even integers");
        int[] numbers = new int[5];
        Console.WriteLine("\n\tPlease enter 5 numbers : ");
        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine("\tNumber " + i+ " : ");
            int num = Convert.ToInt32(Console.ReadLine());
            numbers[i-1] = num; 
        }
        Console.WriteLine("\tOdd Numbers : " + String.Join(",", numbers.Select(x => x).Where(x=>x%2 == 1)));
        Console.WriteLine("\tEven Numbers : " + String.Join(",", numbers.Select(x=> x).Where(x=>x%2 == 0)));
    }
    // Question 5 
    public static bool inside(double x, double y, double x1, double y1, double x2, double y2)
    {
        if((x > x1 && x < x2) && (y > y1 && y < y2))
        {
            return true;
        }
        return false;
    }
    public static void question_5()
    {
        Console.WriteLine("Q.5 Write a function inside(x,y,x1,y1,x2,y2)");
        Console.WriteLine("\tThe point (1,1) lies in between (0.3, 0.5) and (1.1, 0.7) : " + inside(1, 1, 0.3, 0.5, 1.1, 0.7));
        Console.WriteLine("\tThe point (1,1) lies in between (0.5, 0.2) and (1.1, 2) : " + inside(1, 1, 0.5, 0.2, 1.1, 2));
    }
}