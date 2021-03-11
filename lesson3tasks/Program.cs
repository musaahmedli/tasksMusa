using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            

            /*
            #region 6elementli int massivi sort
            int[] intArr = new int[6];
            Console.WriteLine("enter number: ");
            int resp;
            for(int i = 0; i < intArr.Length; i++)
            {
                intArr[i]= Convert.ToInt32(Console.ReadLine());
                
            }
            for(int i = 0; i <= intArr.Length - 2; i++)
            {
                for(int n = 0; n <= intArr.Length-2; n++)
                {
                    if (intArr[n] > intArr[n + 1])
                    {
                        resp = intArr[n + 1];
                        intArr[n + 1] = intArr[n];
                        intArr[n] = resp;
                    }
                }
                foreach(int el in intArr)
                {
                    Console.WriteLine(el+" ");
                }
            }
            #endregion
            */




            /*
            #region foreach
            string[] strArr = new string[5] {"musa","musa1","musa2","musa3","musa4"};
            foreach(string element in strArr)
            {
                Console.WriteLine(element + " ");
            }
            #endregion
            */





            /*
            #region 2misli
            Console.Write("enter the number of elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] intArr = new int[number];
            Console.WriteLine("enter the elements:");
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int el in intArr)
            {
                Console.WriteLine(el*2);
            }
            #endregion
            */





            /*
            #region tek olanlar
            Console.Write("enter the number of elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[]intArr = new int[number];
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int el in intArr)
            {
                if (el % 2 == 1)
                {
                    Console.WriteLine(el);
                }
            }
            #endregion

            */




            /* minimum maximum
            int[] intArr = new int[10] { 321, 534, 132, 4252, 432, 342, 3242, 54354, 1211, 2312 };
            Console.WriteLine(intArr.Min());
            Console.WriteLine(intArr.Max());
            */





            /* 1 den 20 ye cem
            double sum=0;
            for (double i = 1; i < 21; i++)
            {
                double power = Math.Pow(i, 2);
                sum += power;
                
            }
            Console.WriteLine(sum);
            */




            /*
            Console.Write("enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for(int i = 0; i < num; i++)
            {
                int value = rndm.Next(0,200);
                Console.WriteLine(value);
                sum += value;
            }
            Console.WriteLine("the sum of random numbers is : "+sum);
            */




            /*
            Console.Write("enter the row number: ");
            int rowNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the column number: ");
            int colNum = Convert.ToInt32(Console.ReadLine());
            int[,] twoD_Array = new int[rowNum, colNum];
            int sum = 0;
            for (int i = 0; i < twoD_Array.GetLength(0); i++)
            {
                

                for (int a = 0; i < twoD_Array.GetLength(1); i++)
                {
                    int b = rndm.Next(0, 100);
                    twoD_Array[i, a] = b ;
                    sum += b;    
                    
                }
                
            }
            Console.WriteLine(sum);
            */

            Console.ReadKey();
        }
    }
}
