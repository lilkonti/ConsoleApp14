using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Theatre : IDisposable
    {
        //поля класса
        public Genre genre { get; set; }
        public string name { get; set; }
        public string theatre { get; set; }
        public int duration { get; set; }
        public string[] actors = new string[5];
        //конструктор
        public Theatre()
        {
            genre = Genre.comedia;
            name = "Fatal Error";
            theatre = "Nice theatre";
            duration = 1;

            for (int i = 0; i < 5; i++)
            {
                actors[i] = "actor" + Convert.ToString(i);
            }

            Console.WriteLine("generate class");
        }
        //деструктор
        public void Dispose()
        {
            genre = default;
            name = default;
            theatre = default;
            duration = default;
            actors = default;
        }
        //вивід
        public void show()
        {
            Console.WriteLine(name + " it's a " + theatre + "show");
            Console.WriteLine("genre is " + genre + " and his duration - " + duration);
            Console.WriteLine();
            for (int i = 0;i < actors.Length;i++)
            {
                Console.WriteLine("actor: " + actors[i]);
            }
        }
    }
}

