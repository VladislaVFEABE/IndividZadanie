using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividZadanieSultanovFirma
{
    internal class Cotrudniki : IComparable<Cotrudniki>
    {

        public string FullName { get; set; }
        public string Firma { get; set; }
        public string Zakaz { get; set; }
        public DateTime ObrashTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public Cotrudniki(string name, string firma, string zakaz, DateTime obrashTime, DateTime departureTime)
        {
            FullName = name;
            Firma = firma;
            Zakaz = zakaz;
            ObrashTime = obrashTime;
            DepartureTime = departureTime;
        }

        /// <summary>
        /// Реализация интерфейса IComparable для сравнения записей по ФИО сотрудника
        /// </summary>
        /// <param name="employee">Сотрудник для сравнения</param>
        public int CompareTo(Cotrudniki employee)
        {
            return this.FullName.CompareTo(employee.FullName);
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", FullName, Firma, Zakaz, ObrashTime, DepartureTime);
        }

    }
}
