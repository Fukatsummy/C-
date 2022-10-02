using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Третью  задачу никак не могу закончить, не понимаю что не так.

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            /* //Напишите метод, который отображает квадрат из
                //некоторого символа.Метод принимает в качестве параметра: 
                //длину стороны квадрата, символ.
             Square mf = new Square(5);
             mf.DrawSquare();*/
            #endregion Task_1

            #region Task_2
            /*
            //Напишите метод, который проверяет является ли  переданное число «палиндромом». Число передаётся в
            //качестве параметра.Если число палиндром нужно вернуть из метода true, иначе false.
            //Палиндром — число, которое читается одинаково как справа налево, так и слева направо.Например:
            //1221 — палиндром; 3443 — палиндром; 7854 — не палиндром.
            Console.WriteLine("Введите текст: ");
            string text=Console.ReadLine().Replace(" ", "").Trim();
            //Array.Reverse(text);//переворот
            string ftext = string.Empty;
            for(int i=text.Length-1;i>=0;i--)
            {
                ftext += text[i];
            }
            Console.WriteLine(text.Equals(ftext) ? "Палиндром!" : "Не палиндром!");
            //ftext = Console.ReadLine();
            Console.ReadLine();
            */
            #endregion Task_2

            #region Task_3

            //Создайте класс «Веб - сайт». Необходимо хранить в полях класса: название сайта, путь к сайту, описание
            //сайта, ip адрес сайта.Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным
            //полям через методы класса. 

            /*List<Web_site> list = new List<Web_site>();
            list.Add(new Web_site("Inventors", "https://invent.com/", "Website creation and maintenance", "74.125.0.0"));
            */
            Web_site web = new Web_site("", "", "", "");
            web.NewWeb_site(web);

            /*Console.WriteLine("Название сайта");
            string name = Console.ReadLine();
            Console.WriteLine("Как нас найти: ");
            string path = Console.ReadLine();
            Console.WriteLine("Мы занимаемся  ");
            string description = Console.ReadLine();
            Console.WriteLine("Мы находимся по {4} адресу");
            string ip = Console.ReadLine();*/

            #endregion Task_3
        }
    }
    #region Task_1
    /*class Quadro
    {
        public int Base { get; set; }
    }
    interface ISimpleNAngle  //простой Нугольник
    {
        int Base { get; set; }
        int BaseSideAngle { get; set; }
        int NumberSide { get; set; }
    }
    class Square : ISimpleNAngle
    {
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        public int NumberSide { get; set; }
        public Square(int numberSide)
        {
            NumberSide = numberSide;
            BaseSideAngle = 360 / numberSide;
        }
        public void DrawSquare()
        {
            char[] drawChar = new char[8] { ' ', ' ', ' ', ' ', ' ', ' ', ' ',  ' ' };
            for (int i=1;i<drawChar.Length;i++)
            {
                for(int j=0;j< drawChar.Length; j++)
                {
                    drawChar[ j] = '*';
                }
                Console.WriteLine(drawChar);
            }
        }
    }*/
    #endregion Task_1

    //public IEnumerator GetEnumerator()
    //{
    //    return ((IEnumerable)Name).GetEnumerator();
    //}
    //public int CompareTo(object obj)
    //{
    //    return Name.CompareTo((string)obj);
    //}
    //public int Compare(object obj, object obj2)
    //{
    //    return ((Web_site)obj).Name.CompareTo((string)obj);
    //}

    class Web_site : IEnumerable, IComparable
    {
        //string _nameWeb;
        //string _pathWeb;
        //string _descriptionWeb;
        //string _ipWeb;

        public string Name{get;set;}
        public string Path{get;set; }
        public string Description{get;set; }
        public string Ip{ get; set ; }

        public Web_site(string name, string path,string description,string ip)
        {
            Name = name;
            Path = path;
            Description = description;
            Ip = ip;
        }
        public override string ToString()
        {
            return Name + " " + Path + " " + Description + " " + Ip.ToString();
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Name).GetEnumerator();
        }
        public int CompareTo(object obj)
        {
            return Name.CompareTo((string)obj);
        }
        public int Compare(object obj, object obj2)
        {
            return ((Web_site)obj).Name.CompareTo((string)obj);
        }

        internal void NewWeb_site(Web_site web)
        {
            throw new NotImplementedException();
        }
    }
    class Data_Input
    {
        string name, developer;
        public Data_Input(string name, string developer)
        {
            this.name = name;
            this.developer = developer;
        }
        public string GetInfo()
        {
            return string.Format(name, developer);
        }
    }
    public Web_site NewWeb_site(Web_site web)
    {
        Console.Write("Введите название сайта:"); string name = Console.ReadLine();
        Console.Write("Введите путь к сайту:"); string addres = Console.ReadLine();
        Console.Write("Введите описание сайта:"); string description = Console.ReadLine();
        Console.Write("Введите IP адрес сайта:"); string IP = Console.ReadLine();

        Console.WriteLine("Название магазина: " + name + "\nПуть к сайту: " + addres + "\nОписание сайта:" + description + "\nIP адрес сайта: " + IP);
        return web;
    }
    /*class Web
    {
        List<Web_site> Web_sites;
        string Name { get; set; }
        string Path { get; set; }
        string Description { get; set; }
        public Web(string name, string path, string description,List<Web_site>web_sites)
        {
            Name = name;
            Path = path;
            Web_sites = web_sites;
        }
        public void GetWebName()
        {
            Console.WriteLine("Добро пожаловать!");
        }
        public void GetAllDevelopment()
        {
            int index = 1;
            foreach (Web_site web_Site in Web_sites)
            {
                Console.WriteLine("Индекс: {0}{1}", web_Site);
            }
        }
        public void AddDevelopment (Web_site web_Site)
        {
            Web_site.Add(web_Site);
        }



    }*/
}
