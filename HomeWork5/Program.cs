using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ранее в одном из практических заданий вы создавали класс «Магазин». Добавьте к уже созданному классу
            //информацию о площади магазина. Выполните перегрузку +(для увеличения площади магазина на указанную
           //величину), — (для уменьшения площади магазина на указанную величину), == (проверка на равенство площадей магазинов), < и > (проверка на меньше или больше
//площади магазина), != и Equals.Используйте механизм свойств для полей класса.
          
            Book store = new Book("Удивительный мир", "ул.Советская 239", "Книжный", "+7(999)888-77-66", "bookshop@world.com", 35);
            Book store1 = new Book("Сказочник", "ул.Ленина 17", "Книжный", "+7(863)888-77-66", "fairy@mail.ru", 55);
            store.GetShopInfo();
            int newstoreroom = 45; store.Barea += newstoreroom;
            store.GetShopInfo();
            int storeroom = 15; store.Barea -= storeroom;
            store.GetShopInfo();
            Console.WriteLine(store==store1);
            Book shop = new Book("", "", "", "", "", 0);
            shop.AddShop(shop);
            shop.GetShopInfo();
        }
    }
    //class Book
    //{
       /* public string Name
        { get => _nameB; set => _nameB = value; }
        public string Address
        { get => _addressB; set => addressB = value; }
        public string Profile
        { get => _profileB; set => _profileB = value; }
        public string Phone
        { get => _phoneB; set => _phoneB = value; }
        public string Email
        { get => _emailB; set => _emailB = value; }
        public int Area
        { get => _areaB; set => _areaB = value; }
        public int _area { get; private set; }

        public Book(string name, string address, string profile, string phone, int email, int area)//конструктор
        {
            _nameB = name;
            _addressB = address;
            _profileB = profile;
            _phoneB = phone;
            _emailB = email;
            _areaB = area;
        }

        public Book(string v1, string v2, string v3, string v4, string v5)
        {
        }

        public static int operator +(Book area, int addarea)
        {
            area._area += addarea;
            return area._area;
        }
        public static bool Book ==(Book area, Book otherarea)
        {
            return area.Area==otherarea.Area;
        }
    public static bool operator !=(Book area, Book otherarea)
    {
        return area.Area != otherarea.Area;
    }
    public override string ToString()//перегрузка в string
    {
        return "Название магазина: " + Name + " ;\n Адрес: " + Address + ";\n Специализация магазина: " + Profile + ";\n Контактный номер:  " + Phone + ";\n Адресс электронной почты: " + Email + ";\n Площадь магазина: " + Area;
    }
    public void GetBookInfo()
    {
        Console.WriteLine(ToString());
    }*/
    class Book
    {
        string _Bname;
        string _Baddress;
        string _Bprof;
        string _Bphone;
        string _Bemail;
        int _Barea;
        public string Name
        {
            get => _Bname; set => _Bname = value;
        }
        public string Address
        {
            get => _Baddress; set => _Baddress = value;
        }
        public string Profile
        {
            get => _Bprof; set => _Bprof = value;
        }
        public string Phone
        {
            get => _Bphone; set => _Bphone = value;
        }
        public string Email
        {
            get => _Bemail; set => _Bemail = value;
        }
        public int Barea
        {
            get => _Barea; set => _Barea = value;
        }
        //Constructor
        public Book(string name, string address, string prof, string phone, string email, int area)
        {
            _Bname = name;
            _Baddress = address;
            _Bprof = prof;
            _Bphone = phone;
            _Bemail = email;
            _Barea = area;
        }
        public static int operator +(Book Barea, int addarea)
        {
            Barea._Barea += addarea;
            return Barea._Barea;
        }
        public static bool operator ==(Book Barea, Book otherarea)
        {
            return Barea._Barea == otherarea._Barea;
        }
        public static bool operator !=(Book Barea, Book otherarea)
        {
            return Barea._Barea != otherarea._Barea;
        }
        public static bool operator <(Book Barea, Book otherarea)
        {
            return Barea._Barea < otherarea._Barea;
        }
        public static bool operator >(Book Barea, Book otherarea)
        {
            return Barea._Barea > otherarea._Barea;
        }
        public static int operator -(Book Barea, int lowerarea)
        {
            Barea._Barea -= lowerarea;
            return Barea._Barea;
        }
        public Book AddShop(Book shop)
        {
            Console.Write("Введите название магазина:"); string shname = Console.ReadLine();
            Console.Write("Введите адресс магазина:"); string address = Console.ReadLine();
            Console.Write("Введите профиль магазина:"); string buns = Console.ReadLine();
            Console.Write("Введите номер телефона магазина:"); string phone = Console.ReadLine();
            Console.Write("Введите эл.почту магазина:"); string gemail = Console.ReadLine();
            Console.Write("Введите площадь магазина:"); int area = Int32.Parse(Console.ReadLine());
            return shop;
        }
        public override string ToString()
        {
            return " Название магазина: " + Name + ";\n Адресс: " + Address + ";\n Специализация магазина: " + Profile + ";\n Контактный номер: " + Phone + ";\n Адресс электронной почты: " + Email + ";\n Площадь: " + Barea.ToString() + " кв. метров";
        }
        public void GetShopInfo()
        {
            Console.WriteLine(ToString());
        }
        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   _Bname == book._Bname &&
                   _Baddress == book._Baddress &&
                   _Bprof == book._Bprof &&
                   _Bemail == book._Bemail &&
                   _Bphone == book._Bphone &&
                   _Barea == book._Barea;
        }

        public override int GetHashCode()
        {
            GetHashCode hash = new GetHashCode();
            hash.Add(_Bname);
            hash.Add(_Baddress);
            hash.Add(_Bprof);
            hash.Add(_Bemail);
            hash.Add(_Bphone);
            hash.Add(_Barea);
            return hash.ToHashCode();
        }
    }

   
}
