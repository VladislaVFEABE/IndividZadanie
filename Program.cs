using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IndividZadanieSultanovFirma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cotrudniki> ListInfo = new List<Cotrudniki>();
            //Добавление записи в список сотрудников
            ListInfo.Add(new Cotrudniki("Султанов Владислав Анатольевич |", "ВЛАСТААЛ |", "Заказ № 001 |",
                                      new DateTime(2022, 1, 1, 0, 0, 0),
                                      new DateTime(2022, 5, 1, 0, 0, 0)));

            ListInfo.Add(new Cotrudniki("Мошой Никита Валерьевич |", "ВЛАСТААЛ |", "Заказ № 002 |",
                                      new DateTime(2022, 11, 28, 0, 0, 0),
                                      new DateTime(2022, 12, 3, 0, 0, 0)));

            ListInfo.Add(new Cotrudniki("Гениевич Антон Эдикович |", "Шериф |", "Заказ № 003 |",
                           new DateTime(2022, 8, 3, 0, 0, 0),
                           new DateTime(2022, 8, 9, 0, 0, 0)));
            ListInfo.Add(new Cotrudniki("Интерднестрокомовский Кузьма Олегович |", "Хайтек |", "Заказ № 004 |",
                          new DateTime(2023, 1, 2, 0, 0, 0),
                          new DateTime(2023, 1, 9, 0, 0, 0)));


            WriteLine("Все сотрудники: ");
            Vivod_Sotr(ListInfo);
            ListInfo.Sort();

            WriteLine("\nСортировка по ФИО: ");
            Vivod_Sotr(ListInfo);


            ListInfo.Sort(new Record_Comparer_By_Firma());
            WriteLine("\n Сортировка  по ФИРМЕ: ");
            Vivod_Sotr(ListInfo);

            ListInfo.Sort(new Record_Comparer_By_Departure_Time());
            WriteLine("\nЗаписи, отсортированные по дате выполнение заказа:");
            Vivod_Sotr(ListInfo);

        }

        static void Vivod_Sotr(List<Cotrudniki> records)
        {
            WriteLine("ФИО сотрудника\tФИРМА\t Название Заказа,\t Дата Обращения\t    Дата выполнения заказа");
            foreach (Cotrudniki employee_Information in records)
            {
                WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                    employee_Information.FullName,
                    employee_Information.Firma,
                    employee_Information.Zakaz,
                    employee_Information.ObrashTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    employee_Information.DepartureTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            ReadKey();
        }
    }
}
