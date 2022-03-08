using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название процессора");
            string ПользТипПроцессора = Console.ReadLine();
            Console.WriteLine("Введите Объем ОЗУ");
            int ПользОбъемОперПамяти = Convert.ToInt32(Console.ReadLine());

            List<Computer> listComp = new List<Computer>()
            {
                new Computer(){Код="0001",Марка="Dell", ТипПроцессора="Core i3", ЧастотаПроцессора=3.7, ОбъемОперПамяти=4, ОбъемЖесткогоДиска=500, ОбъемПамятиВидеокарты=2, Цена=900, Количество=45},
                new Computer(){Код="0002",Марка="HP", ТипПроцессора="Core i5", ЧастотаПроцессора=3.9, ОбъемОперПамяти=8, ОбъемЖесткогоДиска=1000, ОбъемПамятиВидеокарты=6, Цена=1400, Количество=20},
                new Computer(){Код="0003",Марка="MSI", ТипПроцессора="Core i5", ЧастотаПроцессора=3.1, ОбъемОперПамяти=16, ОбъемЖесткогоДиска=1000, ОбъемПамятиВидеокарты=4, Цена=1700, Количество=32},
                new Computer(){Код="0004",Марка="Acer", ТипПроцессора="Ryzen 7", ЧастотаПроцессора=3.4, ОбъемОперПамяти=12, ОбъемЖесткогоДиска=500, ОбъемПамятиВидеокарты=8, Цена=1900, Количество=15},
                new Computer(){Код="0005",Марка="Asus", ТипПроцессора="Ryzen 9", ЧастотаПроцессора=3.7, ОбъемОперПамяти=32, ОбъемЖесткогоДиска=1000, ОбъемПамятиВидеокарты=8, Цена=2300, Количество=5},
                new Computer(){Код="0006",Марка="Dell", ТипПроцессора="Core i5", ЧастотаПроцессора=3.9, ОбъемОперПамяти=8, ОбъемЖесткогоДиска=2000, ОбъемПамятиВидеокарты=4, Цена=2250, Количество=17},
                new Computer(){Код="0007",Марка="Acer", ТипПроцессора="Core i7", ЧастотаПроцессора=3.7, ОбъемОперПамяти=8, ОбъемЖесткогоДиска=500, ОбъемПамятиВидеокарты=6, Цена=1950, Количество=6},
            };

            //1
            List<Computer> listCompSelectedProcessor = listComp
                .Where(с => с.ТипПроцессора == ПользТипПроцессора)
                .ToList();
            Console.WriteLine("\nСписок компьютеров с указанным названием процессора:");
            foreach (Computer c in listCompSelectedProcessor)
                Console.WriteLine("Код={0}, Марка={1}", c.Код, c.Марка);

            //2
            List<Computer> listCompSelectedMemory = listComp
                .Where(с => с.ОбъемОперПамяти >= ПользОбъемОперПамяти)
                .ToList();
            Console.WriteLine("\nСписок компьютеров с ОЗУ не ниже указанного:");
            foreach (Computer c in listCompSelectedMemory)
                Console.WriteLine("Код={0}, Марка={1}", c.Код, c.Марка);

            //3
            List<Computer> listCompRiseCost = listComp
                .OrderBy(с => с.Цена)
                .ToList();
            Console.WriteLine("\nCписок, отсортированный по увеличению стоимости");
            foreach (Computer c in listCompRiseCost)
                Console.WriteLine($"{c.Код} {c.Марка} {c.ТипПроцессора} {c.ЧастотаПроцессора} {c.ОбъемОперПамяти} {c.ОбъемЖесткогоДиска} {c.ОбъемПамятиВидеокарты} {c.Цена} {c.Количество}");

            var listCompGroup = listComp
                .GroupBy(g => g.ТипПроцессора)
                .ToList();
            //4
            Console.WriteLine("\nCписок, сгруппированный");
            foreach (var comp in listCompGroup)
            {
                Console.WriteLine($"{comp.Key}");
                foreach (var c in comp)
                    Console.WriteLine($"{c.Код} {c.Марка} {c.ТипПроцессора} {c.ЧастотаПроцессора} {c.ОбъемОперПамяти} {c.ОбъемЖесткогоДиска} {c.ОбъемПамятиВидеокарты} {c.Цена} {c.Количество}");
            }
            //5
            Computer expComp = listCompRiseCost
              .Last();
            Console.WriteLine("\nСамый дорогой компьютер-Код: {0}. Цена: {1} ", expComp.Код, expComp.Цена);

            Computer cheapComp = listCompRiseCost
              .First();
            Console.WriteLine("\nСамый бюджетный компьютер-Код: {0}. Цена: {1}", cheapComp.Код, cheapComp.Цена);

            //6
            bool A = listComp
                .Any(с => с.Количество >= 30);
            if (A == true) 
                Console.WriteLine("\nЕсть хотя бы один компьютер в количестве не менее 30 штук");
            else
                Console.WriteLine("\nНет ни одного компьютера в количестве не менее 30 штук");


            Console.ReadKey();

        }
    }

    public class Computer
    {
        public string Код { get; set; }
        public string Марка { get; set; }
        public string ТипПроцессора { get; set; }
        public double ЧастотаПроцессора { get; set; }
        public int ОбъемОперПамяти { get; set; }
        public int ОбъемЖесткогоДиска { get; set; }
        public int ОбъемПамятиВидеокарты { get; set; }
        public double Цена { get; set; }
        public int Количество { get; set; }
    }








}
