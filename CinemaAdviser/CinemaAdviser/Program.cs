using System;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Я помогу тебе выбрать фильм на вечер :)"); //вывод строки

            Console.WriteLine("Как мне к тебе обрщаться?"); //вывод строки
            String name = Console.ReadLine(); //запрос на ввод имени

            Console.WriteLine("Привет, " + name); //вывод строки с введённым именем 

            Console.WriteLine("В каком жанре вы хотете посмотреть фильм? комедия, фантастика, ужасы или драма"); //вывод строки
            String genre = Console.ReadLine(); //запрос на ввод жанра

            if (genre == "Комедия" || genre == "комедия") //условие
            {
                Console.WriteLine("* Солдаты неудачи");
                Console.WriteLine("* Маска");
                Console.WriteLine("* Зачётный препод");
            }

            else if (genre == "Фантакстика" || genre == "фантастика")
            {
                Console.WriteLine("* Аладдин");
                Console.WriteLine("* Веном");
                Console.WriteLine("* Пираты карибского моря");
            }

            else if (genre == "Ужасы" || genre == "ужасы")
            {
                Console.WriteLine("* Пила");
                Console.WriteLine("* Синестер");
                Console.WriteLine("* Бабадук");
            }

            else if (genre == "Драма" || genre == "драма")
            {
                Console.WriteLine("* Титаник");
                Console.WriteLine("* Хатико");
                Console.WriteLine("* Один дома");
            }

            else
            {
                Console.WriteLine("Такого жанра нет в нашей базе :(");
            }

            Console.ReadLine();
        }
    }
}
