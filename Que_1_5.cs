namespace ProblemSet1
{
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
            // Printing the result with object
            Console.WriteLine("\t"+o +" - "+ o.GetType().Name);
        }
        
        // Question 2 string questions
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
            List<string> words = new List<string> { "Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus", "Bababadalgharaghtakamminarronnkonn" };
            
            // Using SQL functions for list
            //int maxLength = words.Max(x => x.Length);
            //Console.WriteLine("\tC. Longest words amongst given three word(s) is/are : "+String.Join(",",words.Select(x=> x).Where(x=>x.Length == maxLength)));
            
            // Initiliaze maxlength with  value 0
            int maxLength = 0;

            // Logic to get max length from all words
            foreach(var word in words)
            {
                int wordLength = word.Length;
                if(maxLength < wordLength)
                {
                    maxLength = wordLength;
                }
            }

            // Logic to get max length words
            List<string> maxLengthWords = new List<string>();
            foreach(var word in words)
            {
                if(word.Length == maxLength)
                {
                    maxLengthWords.Add(word);
                }
            }

            // Printing result, used join to format list of strings to comma seperated string
            Console.WriteLine("\tC. Longest words amongst given three word(s) is/are : " + String.Join(",", maxLengthWords));

            // Question 4

            // Initialize array of words
            string[] wordArr = { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };
            // Using array sort function to sort an array
            Array.Sort(wordArr);
            // Fetching first element and printing the result
            Console.WriteLine("\tD. The First composer : " + wordArr[0]);
            // Fetching last element and printing the result
            Console.WriteLine("\tE. The Last composer : " + wordArr[wordArr.Length - 1 ]);
        }

        // Question 3 : function triangleArea(a,b,c)
        public static void question_3()
        {
            // Printing the result of triangleArea function 
            Console.WriteLine("\nQ.3 Implement function triangleArea(x,y,x)\n\tArea of triangle : "+triangleArea(2,2,2));
        }
        public static double triangleArea(double x, double y, double z)
        {
            // Formula for s
            double s = (x+y+z)/2;
            // Creating a formula usnig Math Sqrt function
            double area = Math.Sqrt((s * (s - x) * (s - y) * (s - z)));
            // Returns an area
            return area;
        }

        // Question 4 Separate odd and even integers
        public static void question_4()
        {
            Console.WriteLine("\nQ.4 Write a program in C# Sharp to separate odd and even integers");
            // Empty array of integer - length 5
            int[] numbers = new int[5];
            Console.WriteLine("\n\tPlease enter 5 numbers : ");
            // Asking user to input 5 numbers
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("\tNumber " + i+ " : ");
                int num = Convert.ToInt32(Console.ReadLine());
                numbers[i-1] = num; 
            }
            var oddNumbers = new List<int>();
            var evenNumbers = new List<int>();
            foreach (int i in numbers)
            {
                if (i % 2 == 1) oddNumbers.Add(i);
                if (i % 2 == 0) evenNumbers.Add(i);
            }
            // Printing odd and even numbers using LINQ Method select and where
            //Console.WriteLine("\tOdd Numbers : " + String.Join(",", numbers.Select(x => x).Where(x=>x%2 == 1)));
            //Console.WriteLine("\tEven Numbers : " + String.Join(",", numbers.Select(x=> x).Where(x=>x%2 == 0)));
            
            // String.Join function will convert list into comma seperated string 
            Console.WriteLine("\tOdd Numbers : " + String.Join(", ",oddNumbers));
            Console.WriteLine("\tEven Numbers : " + String.Join(", ",evenNumbers));
        }
        // Question 5 : A function inside(x,y,x1,y1,x2,y2)
        public static bool inside(double x, double y, double x1, double y1, double x2, double y2)
        {
            // logic for whether point is inside rectangle or not
            if((x > x1 && x < x2) && (y > y1 && y < y2))
            {
                // Given point is inside a rectangle
                return true;
            }
            // Given point is not inside a rectangle
            return false;
        }
        public static void question_5()
        {
            Console.WriteLine("Q.5 Write a function inside(x,y,x1,y1,x2,y2)");
            // Printing output using inside function - calling function with parameters
            Console.WriteLine("\tThe point (1,1) lies in between (0.3, 0.5) and (1.1, 0.7) : " + inside(1, 1, 0.3, 0.5, 1.1, 0.7));
            Console.WriteLine("\tThe point (1,1) lies in between (0.5, 0.2) and (1.1, 2) : " + inside(1, 1, 0.5, 0.2, 1.1, 2));
        }
    }

}
