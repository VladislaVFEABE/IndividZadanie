using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividZadanieSultanovFirma
{
    internal class Record_Comparer_By_Departure_Time : IComparer<Cotrudniki>
    {
        /// <param name="sotr_one">Параметр sotr_one </param>
        /// <param name="sotr_two">Параметр sotr_two для сравнения</param>
        public int Compare(Cotrudniki sotr_one, Cotrudniki sotr_two)
        {
            return sotr_one.DepartureTime.CompareTo(sotr_two.DepartureTime);
        }
    }
}
