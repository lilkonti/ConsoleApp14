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
    internal class Film
    {
        //поля класса
        public Genre genre { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int duration { get; set; }
        public int issue { get; set; }
        //конструктор
        public Film() 
        {
            genre = Genre.comedia;
            name = "Fatal Error";
            description = "Nice film";
            duration = 1;
            issue = 1924;
            Console.WriteLine("generate class");
        }
        //деструктор
        ~Film() 
        {
            genre = default;
            name = default;
            description = default;
            duration = default;
            issue = default;
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
