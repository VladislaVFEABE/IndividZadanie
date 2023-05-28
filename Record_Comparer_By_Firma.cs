using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividZadanieSultanovFirma
{
    internal class Record_Comparer_By_Firma : IComparer<Cotrudniki>
    {
        /// <param name="employee_x"></param>
        /// <param name="employee_y"></param>
        public int Compare(Cotrudniki employee_x, Cotrudniki employee_y)
        {
            return employee_x.Firma.CompareTo(employee_y.Firma);
        }
    }
}
