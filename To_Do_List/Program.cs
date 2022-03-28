﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using To_Do_List.Class;

namespace To_Do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a = 0;
            List<Work> L = new List<Work>();

            Start();

            void Start()
            {


                Console.WriteLine("Выберете тип операции  1) добавить 2) удалить 3) информация 4) очистить консоль ");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Add_Work();
                }
                else if (x == 2)
                {
                    Delete();
                }
                else if (x == 3)
                {
                    Info();
                }
                else if (x == 4)
                {
                    Console.Clear();
                    Start();
                }
                else
                {
                    Start();
                }

            }

            void Info()
            {
                foreach (Work w in L)
                {
                    Console.WriteLine();
                    Console.WriteLine(w.Number);
                    Console.WriteLine(w.Name.ToString());
                    Console.WriteLine(w.Time.ToString());
                    Console.WriteLine(w.Description.ToString());
                    Console.WriteLine();

                }
                Start();
            }

            void Add_Work()
            {
                Work W = new Work();


                Console.WriteLine("Введите название");
                W.Name = Console.ReadLine();

                Console.WriteLine("Введите дату в формате дд.мм.гггг ");
                W.Time = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Введите описание ");
                W.Description = Console.ReadLine();

                L.Add(W);

                L[a] = (W);

                a++;
                W.Number = W.Number + a;
                foreach (Work w in L)
                {
                    Console.WriteLine();
                    Console.WriteLine(w.Number);
                    Console.WriteLine(w.Name.ToString());
                    Console.WriteLine(w.Time.ToString());
                    Console.WriteLine(w.Description.ToString());
                    Console.WriteLine();

                }

                Start();
            }
            void Delete()
            {
                Console.WriteLine("Введите номер задачи");
                int y = int.Parse(Console.ReadLine());
                try
                { L.Remove(L[--y]); }
                catch
                {
                    Console.WriteLine("Не удалось удалить");
                }

                Start();
            }

            /*
            int a = 0;
            int w;
            Random r = new Random();
            w = r.Next(0, 1000);
            L.Add(a);
            L[a] = (w);
            Console.WriteLine(L[a].ToString());
            a++;
            */

        }
    }
}