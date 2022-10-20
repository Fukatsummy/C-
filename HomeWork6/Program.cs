using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализовать программу “Строительство дома”
            //Реализовать:
            //•	 Классы
            //■ House(Дом), Basement(Фундамент), Walls(Стены),Door(Дверь), Window(Окно), Roof(Крыша);
            //■ Team(Бригада строителей), Worker(Строитель),TeamLeader(Бригадир).
            //•	 Интерфейсы
            //■ IWorker, IPart.Все части дома должны реализовать интерфейс IPart(Часть дома), для рабочих и бригадира предоставляется
            //базовый интерфейс IWorker(Рабочий).Домашнее задание №6 Бригада строителей(Team) строит дом(House). Дом
            //состоит из фундамента(Basement), стен(Wall), окон(Window), дверей(Door), крыши(Part).Согласно проекту, в доме должно быть 1 фундамент,
            //4 стены, 1 дверь, 4 окна и 1 крыша.Бригада начинает работу, и строители последовательно“строят” дом, начиная с фундамента.Каждый строитель
            //не знает заранее, на чём завершился предыдущий этап строительства, поэтому он “проверяет”, что уже построено и продолжает работу. Если в игру вступает бригадир
            //(TeamLeader), он не строит, а формирует отчёт, что уже построено и какая часть работы выполнена.
            //В конечном итоге на консоль выводится сообщение, что строительство дома завершено и отображается “рисунок дома” (вариант отображения выбрать самостоятельно).

            List<Worker> workers = new List<Worker> { new Worker("Иванов"), new Worker("Петров"), new Worker("Сидоров"), new Worker("Жуков") };
            House house = new House();
            Team team = new Team("Баранкин", workers);

            Console.WriteLine(team.Name);

            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                team.w[r.Next(0, 3)].Create(house, team.d);
            }

            foreach (var a in team.d.report)
            {
                Console.WriteLine(a);
            }

            team.d.Report();
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                team.w[r.Next(0, 3)].Create(house, team.d);
            }

            foreach (var a in team.d.report)
            {
                Console.WriteLine(a);
            }
            team.d.Report();

            house.Drow(team.d);
        }
    }
    interface IWorker
    {
        string Name { get; }
    }
    interface IPart
    {
        void Create (House house);
    }
    class House 
    {
        public Basement basement;
        public List<Walls> walls;
        public List<Window> window;
        public Door door;
        public Roof roof;
        public void Drow(TeamLeader d)
        {
            string house = @"           
                    ________[_]________    
                   /\        ______    \   
                  //_\       \    /\    \  
                 //___\       \__/  \    \
                //_____\       \ |[]|     \
               //_______\       \|__|      \
              /XXXXXXXXXX\                  \
             /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";
            Console.WriteLine(house);
        }
          
    }
    class Basement :IPart
    {
        public void Create (House house)
        {
            house.basement = new Basement();
        }
    }
    class Walls :IPart
    {
        public void Create (House house)
        {
            house.walls.Add(new Walls());//потому что их несколько
        }
    }
    class Door :IPart
    {
        public void Create(House house)
        {
            house.door = new Door();// потому что одно
        }
    }
    class Window :IPart
    {
        public void Create (House house)
        {
            house.window.Add(new Window());
        }
    }
    class Roof :IPart
    {
        public void Create (House house)
        {
            house.roof = new Roof();
        }
    }
    class Team :IWorker
    {
        public TeamLeader d;
        public List<Worker> w;
        public string Name { get; set; }
        public Team (string name, List<Worker> workers)
        {
            d = new TeamLeader(name);
            w = workers;
        }
    }
    class Worker : IWorker
    {
        string Name { get; set; }

        string IWorker.Name => Name;

        public Worker(string name)
        { Name = name; }

        public void Create(House house, TeamLeader t)
        {
            if (house.basement == null)
            {
                Basement basement = new Basement();
                basement.Create(house);
                t.report.Add($"{Name} залил фундамент");
            }
            else if (house.walls == null || house.walls.Count < 4)
            {
                if (house.walls == null) house.walls = new List<Walls>();
                Walls wall = new Walls();
                wall.Create(house);
                t.report.Add($"{Name} возвел стену {house.walls.Count}");
            }
            else if (house.roof == null)
            {
                Roof roof = new Roof();
                roof.Create(house);
                t.report.Add($"{Name} накрыл крышу");
            }
            else if (house.door == null)
            {
                Door door = new Door();
                door.Create(house);
                t.report.Add($"{Name} установил дверь");
            }
            else if (house.window == null || house.window.Count < 4)
            {
                if (house.window == null) house.window = new List<Window>();
                Window window = new Window();
                window.Create(house);
                t.report.Add($"{Name} установил окно {house.window.Count}");
            }
        }
    }
    class TeamLeader :IWorker
    {
       string Name { get; set; }
        public List<string> report = new List<string>();
        string IWorker.Name => Name;
        public TeamLeader(string name)
        {
            Name = name;
        }
        public void Report()
        {
            Console.WriteLine($"Бригадир {Name} подготовил отчет по проделаной работе.");
        }
    }
    
}
