using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleAppOOP
{
    class Фильмы : Attribute
    {
        public string Name { set; get; }
        string название;
        int Год_выпуска;
        public abstract void Продолжительность();
        public void getназвание()
        {
            Console.WriteLine(название);
        }
    }
}
