using System;

namespace MMLogo
{
    class Program
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            char[,] m = new char[N + 1, 10 * N];

            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    m[row, col] = '-';
                }
            }

            fillMatrix(m, N);
            printMatrix(m);
        }
        public static void printMatrix(char[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    Console.Write(m[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void draw(char[,] m, int row, int col, int N)
        {
            for (int i = 0; i < N; i++)
            {
                m[row, col + i] = '*';
            }
        }

        public static void fillMatrix(char[,] m, int N)
        {
            int[] tops = { N, 3 * N, 6 * N, 8 * N };
            foreach (int col in tops)
            {
                for (int row = 0; row < N + 1; row++)
                {
                    draw(m, row, col - row, N);
                    draw(m, row, col + row, N);

                }
            }
        }
    }
}


//fillMatrix(m, n);
//printMatrix(m);

//int n = int.Parse(Console.ReadLine());
//int countStars = 0;
//bool newLineCheck = false;
//bool countBlankSpaces = false;



//for (int i = n + 1; i <= n + 1; i--)
//{
//    if (countStars == n * 2)
//    {
//        for (int middle = 1; middle <= n; middle++)
//        {
//            Console.Write("-");
//        }
//    }
//    for (int im = 1; im <= 2; im++)
//    {
//        for (int j = 1; j <= 3; j++)
//        {
//            Console.Write("-");
//        }

//        if (countStars == n * 4)
//        {
//            if(newLineCheck)
//            Console.WriteLine();
//            newLineCheck = true;
//            break;
//        }
//        for (int k = 1; k <= 3; k++)
//        {
//            Console.Write("*");
//            countStars++;

//        }

//    }


//}
//Console.ReadLine();















//        int n = int.Parse(Console.ReadLine()); //3

//        int stars, minuses;
//        bool middlePart = false;
//        int countStars = 0;


//        for (int rows = 0; rows <= n + 1; rows++)
//        {                
//            for (int row = 1; row <= 2; row++)
//            {
//                if (countStars == 4 * n)
//                {
//                    for (int i = 1; i <= n; i++)
//                    {
//                        Console.Write("-"); //---                   
//                    }
//                    Console.WriteLine();
//                    break;
//                }
//                if (countStars == 2 * n)
//                {
//                    for (int i = 1; i <= countStars; i++)
//                    {
//                        Console.Write("-"); //---

//                    }
//                    middlePart = true;
//                }
//                if (middlePart)
//                {
//                    for (stars = 1; stars <= n; stars++)
//                    {
//                        Console.Write("*"); //***
//                        countStars++;
//                    }
//                    middlePart = false;
//                }
//                for (minuses = 1; minuses <= n; minuses++)  //i=1
//                {
//                    Console.Write("-"); //---

//                    if (minuses == n)
//                    {
//                        for (stars = 1; stars <= n; stars++)
//                        {
//                            Console.Write("*"); //***
//                            countStars++;
//                        }
//                    }
//                }
//            }
//        }


//    }
