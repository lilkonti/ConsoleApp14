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
        public StringBuilder name { get; set; }
        public StringBuilder theatre { get; set; }
        public StringBuilder duration { get; set; }
        public List<string>actors = new List<string>();
        //конструктор
        public Theatre()
        {
            genre = Genre.comedia;
            name = new StringBuilder("Fatal Error");
            theatre = new StringBuilder("Nice theatre");
            duration = new StringBuilder(1);

            for (int i = 0; i < 5; i++)
            {
                actors.Add("actor" + Convert.ToString(i));
            }

            Console.WriteLine("generate class");
        }
        //деструктор
        public void Dispose()
        {
            genre = default;
            name.Clear();
            theatre.Clear();
            duration.Clear();
            actors.Clear();
        }
        //вивід
        public void show()
        {
            Console.WriteLine(name + " it's a " + theatre + "show");
            Console.WriteLine("genre is " + genre + " and his duration - " + duration);
            Console.WriteLine();
            foreach (var actor in actors)
            {
                Console.WriteLine("actor: " + actor);
            }
        }
    }
}

