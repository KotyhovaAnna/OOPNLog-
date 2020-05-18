using ConsoleAppOOP;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace OOPжанры
{
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        [Фильмы(Name = "выполнила :Котыхова Анна")]
        static void Main(string[] args)
        {
            try
            {
                int s = int.Parse(Console.ReadLine());
            }
            catch (FormatException s)
            {
                log.Info("Это отличный фильм!", s.Source);
            }
            //List<Фантастика> k = new List<Фантастика>();
            //Фантастика Гарри_Поттер = new Фантастика();
            //Гарри_Поттер.namef = "Гарри Поттер. Орден Феникса";
            //Гарри_Поттер.namedirector = "Дэвид Йейтс";
            //Фантастика Властелин_Колец = new Фантастика();
            //Властелин_Колец.namef = "Властелин Колец.Братство Кольца";
            //Властелин_Колец.namedirector = "Питер Джексон";
            //Фантастика Начало = new Фантастика();
            //Начало.namedirector = "Кристофер Нолан";
            //k.Add(Гарри_Поттер);
            //k.Add(Властелин_Колец);
            //k.Add(Начало);
            //var orderedФантастика = from i in k
            //                        orderby i.namedirector
            //                        select i;
            foreach (Фантастика i in orderedФантастика)
            {
                Console.WriteLine(i.namedirector);
            }
        }
    }
}
