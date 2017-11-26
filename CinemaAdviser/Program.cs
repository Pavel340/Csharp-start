using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте," + name);

            Console.WriteLine("Фильм какого жанры вы бы отели посмотреть: комедия, драма, фантастика, эротика.");
            String genre = Console.ReadLine();

            Console.WriteLine("В таком случае рекомендую посмотреть вам следующие фильмы:");

            if (genre == "комедия")
            {
                Console.WriteLine("* Иван Васильевич меняет профессию");
                Console.WriteLine("* Операция 'Ы' и другие приключения Шурика");
                Console.WriteLine("* Назад в будущее");
                Console.WriteLine("* В джазе только девушки");
            }
            else if(genre == "драма")
            {
                Console.WriteLine("* Зеленая миля");
                Console.WriteLine("* Побег из Шоушенка");
            }
            else if (genre == "фантастика")
            {
                Console.WriteLine("* Люди икс");
                Console.WriteLine("* Черепашки ниндзя");
            }
            else if (genre == "эротика")
            {
                Console.WriteLine("Сколько вам лет?");
                String yearString = Console.ReadLine();
                int years = Int32.Parse(yearString);
                if(years < 18)
                {
                    Console.WriteLine("К сожалению, этот жанр доступен для пользователей 18+");
                    Console.WriteLine("Приходите через " + (18 - years) + " лет");
                }
                else
                {
                    Console.WriteLine("* Эммануэль");
                    Console.WriteLine("* Нимфоманка");
                }
                
            }

            Console.ReadLine();
        }
    }
}
