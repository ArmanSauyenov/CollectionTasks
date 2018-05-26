using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    //Курс: Платформа Microsoft.NET и язык программирования C#
    //
    //Тема: Использование коллекций.

    class Program
    {
        static void Main(string[] args)
        {
            //1. Создать коллекцию List < int > .Вывести на экран позицию и значение элемента, 
            //   являющегося вторым максимальным значением в коллекции.Вывести на экран сумму
            //   элементов на четных позициях.

            //2. Удалить все нечетные элементы списка List<int>

            //Task 1,2
            //List<int> DC = new List<int>();
            //Random ran = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    DC.Add(ran.Next(1, 100));
            //}
            //DC = DC.OrderBy(o => o).ToList();
            //Console.WriteLine(DC[DC.Count - 1]);
            //int sum = 0;
            //for (int i = 0; i < DC.Count; i = i + 2)
            //{
            //    Console.WriteLine(" elements " + DC[i]);
            //    DC.Remove(i); //delete, task 2
            //    sum += DC[i];
            //}
            //Console.WriteLine(" sum " + sum);

            //3. Дана коллекция типа List<double>.Вывести на экран элементы списка,
            //   значение которых больше среднего арифметического всех элементов коллекции.

            ////task3
            //double avgTask3 = 0;
            //List<double> GQ = new List<double>();
            //Random ran = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    GQ.Add(ran.Next(1, 100));
            //}
            //avgTask3 = GQ.Sum(o => o) / GQ.Count;
            //Console.WriteLine(" sum " + avgTask3);
            //foreach (var item in GQ)
            //    if (item > avgTask3)
            //        Console.WriteLine("value more than avg1" + item);

            //foreach (var item in GQ.Where(o=>o> avgTask3))
            //    Console.WriteLine("value more than avg2" + item);

            //4. Напечатать содержимое текстового файла t, выписывая литеры каждой его
            //   строки в обратном порядке.

            //task4
            //string str = "sdljhdsflgdsgsdlkhgfklhgflk'hfkl'hhgd";
            //List<char> XX = str.ToList();
            //XX.Reverse();
            //foreach (var item in XX)
            //{
            //    Console.Write(item);
            //}

            //5. Даны 2 строки s1 и s2. Из каждой можно читать по одному символу.
            //   Выяснить, является ли строка s2 обратной s1.

            //task5
            //string s1 = "TOP";
            //string s2 = "POT";
            //string s3 = "";
            //foreach (char item in s1.Reverse())
            //{
            //    s3 += item;
            //}
            //if (s3 == s2)
            //{ Console.WriteLine("Victory"); }

            //6. Дан текстовый файл. За один просмотр файла напечатать элементы файла
            //   в следующем порядке: сначала все слова, начинающиеся на гласную букву, 
            //   потом все слова, начинающиеся на согласную букву, сохраняя исходный порядок 
            //   в каждой группе слов.

            //task6
            string text = "be or not to be is a question";
            List<string> Alen = new List<string>();
            Alen = text.Split(' ').ToList();
            string bookva = "aoieu";
            foreach (var item in Alen)
            {
                if (bookva.Contains(item[0]))
                    Console.WriteLine(item);
            }
            foreach (var item in Alen)
            {
                if (!bookva.Contains(item[0]))
                    Console.WriteLine(item);
            }
        }
    }
}
