using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //練習if else
            Console.WriteLine("請輸入數字:");
            
            var input = Console.ReadLine();
            int inputInt = int.Parse(input);

            if(inputInt % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if(inputInt >= 2 && inputInt <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if(inputInt >= 6 && inputInt <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
            Console.WriteLine();
            Console.ReadLine();

            //練習迴圈
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);
            Console.WriteLine();

            //印出星星
            var a = Console.ReadLine();
            int b = int.Parse(a);
            int j,k;
            for(j=1; j <= b; j++)
            {
                for(k=1; k<=j; k++)
                {
                        Console.Write("*");
                }
                Console.WriteLine();
            }


            //輸入n印出
            var n = Console.ReadLine();
            int m = int.Parse(n);

            for(int v = 1; v<=m; v++)
            {
                Console.WriteLine(n + "*" + v + "=" + (m*v));
            }
            Console.WriteLine();

            //99乘法表
            int x, y;

            for( x = 2; x <= 9; x++)
            {
                for(y = 1; y <=9; y++)
                {
                    Console.Write(x + "*" + y + "=" + (x*y) + "\n");
                }
                Console.WriteLine();
            }

            //陣列練習
            int[] studentNo = { 1, 2, 3, 4, 5 };
            string[] studentName = { "jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computerScore = { 80, 65, 100, 98, 83 };
            int[] progarmScore = { 75, 67, 93, 25, 82 };
            int[] animationScore = { 60, 62, 91, 50, 87 };

            while(true)
            {
                Console.WriteLine("輸入座號(1-5):");
                var num = Console.ReadLine();
                int inputstudentNo = int.Parse(num);
                int arrayIndex = Array.IndexOf(studentNo, inputstudentNo);
                if(arrayIndex >= 0)
                {
                    Console.WriteLine("姓名:" + studentName[arrayIndex]);
                    Console.WriteLine("電腦概論:" + computerScore[arrayIndex]);
                    Console.WriteLine("程式設計:" + progarmScore[arrayIndex]);
                    Console.WriteLine("動畫設計:" + animationScore[arrayIndex]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("座號超出範圍");
                }
            }
        }
    }
}
