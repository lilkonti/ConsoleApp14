using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    enum Genre
    {
        triller,
        comedia,
        fiting,
        detective
    }
    internal class Film : IDisposable
    {
        //поля класса
        public Genre genre { get; set; }
        public StringBuilder name { get; set; }
        public StringBuilder description { get; set; }
        public StringBuilder duration { get; set; }
        public StringBuilder issue { get; set; }
        //конструктор
        public Film() 
        {
            genre = Genre.comedia;
            name = new StringBuilder("Fatal Error");
            description = new StringBuilder("Nice film");
            duration = new StringBuilder("1 hour");
            issue = new StringBuilder(1984);
            Console.WriteLine("generate class");
        }
        //деструктор
        public void Dispose() 
        {
            genre = default;
            name.Clear();
            description.Clear();
            duration.Clear();
            issue.Clear();
        }
        //вивід
        public void show()
        {
            Console.WriteLine(name + " it's a " + description);
            Console.WriteLine("this film issue in " + issue + " and his duration - " + duration);
            Console.WriteLine("Genre: " + genre);
        }
    }
}
