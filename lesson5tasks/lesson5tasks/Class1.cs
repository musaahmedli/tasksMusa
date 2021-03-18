using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5tasks
{
    public class Class1
    {
        private int Id;
        private string Name;
        private string Surname;
         
        public Class1(int id, string name,string surname)
        {
            this.Id= id;
            this.Name = name;
            this.Surname = surname;
            Console.WriteLine(id + " " + name + " " + surname);
        }

        public void Userdata(int id,string name,string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            Console.WriteLine(id+" "+name+" "+surname);
        }
       
    }
    public class Animal
    {
        public string Name;
        public string Type;
        public int Age;


        public void Animalprint(int age,string name,string type)
        {
            this.Age = age;
            this.Name = name;
            this.Type = type;
            Console.WriteLine(age +" " +name +" " +type);
        }
    }
    public class Randomg
    {
        public void Randomgen(params int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 100);
            }
            foreach(int el in arr)
            {
                Console.WriteLine(el);
            }

        }
    }
    public class Overloads
    {
        public string Meth1(string input1,string input2)
        {
            return input1 + input2;
        }
        public string Meth2(string str1, string str2,string str3)
        {
            return str1 + str2 + str3;
        }
    }
    public class Array
    {
        
        public int Sumelementsarray(params int[] arr)
        {
            int sum=0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int el in arr)
            {
                sum += el;
            }
            return sum;
        }
    }
    public class Mathclass
    {
        public int Sum(int a ,int b)
        {
            return a + b;
        }
        public int Subtract(int a,int b)
        {
            return a - b;
        }
        public int Mulitplication(int a,int b)
        {
            return a * b;
        }
        public int Division(int a,int b)
        {
            return a / b;
        }
    }

}
