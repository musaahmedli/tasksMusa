using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region animal class
            //Animal animal = new Animal();
            //animal.Name = "bob";
            //animal.Type = "dog";
            //animal.Age = 3;
            //Console.WriteLine(animal.Age+" "+animal.Name+" "+ animal.Type);
            //animal.Animalprint(5,"bob","dog");
            #endregion

            #region 3 fieldli class yaradin ve constructor cagirin
            //         Class1 class1 = new Class1(5, "musa", "ehmedov");

            #endregion

            #region random ededler liste yig
            //Randomg rg = new Randomg();
            //Console.Write("element sayi: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] intArr = new int[num];
            //rg.Randomgen(intArr);
            #endregion

            #region overload methodlar
            //Overloads over = new Overloads();
            //Console.WriteLine(over.Meth1("musa", "ehmedov"));
            //Console.WriteLine(over.Meth2("musa", "ehmedov", "terlan oglu"));
            #endregion

            #region arrayin elementleri cemi
            //Array objArr = new Array();
            //Console.Write("number of elements: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[number];
            //Console.WriteLine(objArr.Sumelementsarray(arr));

            #endregion

            #region toplama vurma cixma
            //Mathclass objMath = new Mathclass();
            //Console.WriteLine("bolme: "+ objMath.Division(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            //Console.WriteLine("cem: "+objMath.Sum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            //Console.WriteLine("cixma: "+objMath.Subtract(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            //Console.WriteLine("vurma: "+objMath.Mulitplication(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

            #endregion

            #region texmin et
            //Random rn = new Random();
            //int number = rn.Next(1,100);
            //Console.WriteLine(number);
            //bool test = true;
            //while (test)
            //{
            //    Console.WriteLine("enter number: ");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (input < number)
            //    {
            //        Console.WriteLine("enter greater value: ");
            //    }
            //    else if (input > number)
            //    {
            //        Console.WriteLine("enter less value: ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("found it!");
            //        test = false;
            //    }
            //}
            #endregion

            #region 10 elementli dictionary
            //Console.WriteLine("enter key value pairs: ");
            //Dictionary<string, string> dict = new Dictionary<string, string> ();
            //for(int i = 0; i < 10; i++)
            //{
            //    dict.Add(Console.ReadLine(), Console.ReadLine());
            //}
            //foreach(KeyValuePair<string,string> el in dict) 
            //{
            //    if (el.Key.Contains( "test"))
            //    {
            //        Console.WriteLine(el.Key + " " + el.Value);
            //    }
            //}
            #endregion


            Console.ReadKey();

        }
    }
}
