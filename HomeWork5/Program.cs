using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создайте приложение «Список книг для прочтения». Приложение должно позволять добавлять книги в список, удалять книги из списка, проверять есть ли книга в
            //списке, и т. д.Используйте механизм свойств, перегрузки операторов, индексаторов.

            List<Book> list = new List<Book>();
            list.Add(new Book("Нейронные сети и глубокое обучение", "Москва", "Обучающая литература", "Чару Аггарвал", 754, 2020, 500));
            list.Add(new Book("PIC - микроконтроллеры", "Лондон", "Руководство", "Сид Катцен", 651, 2010, 450));
            list.Add(new Book("Криптография и безопастность в технологии .NET", "Москва", "П.Торстейнсон", 482, 2020, 550));
        }
    }
}
