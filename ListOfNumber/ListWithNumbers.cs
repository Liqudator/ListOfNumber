using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNumber
{
    /// <summary>
    /// Класс для хранения коллекции чисел.
    /// </summary>
    public static class ListWithNumbers
    {
        /// <summary>
        /// Коллекция int и decimal чисел.
        /// </summary>
        static readonly List<int> intNumbers = new List<int>() { 1, -2, -5, 3, 4, 0, 7, -4 };
        static readonly List<decimal> decimalNumbers = new List<decimal> { 1, 3, 6, 78, 23, 23, 5, 8 };
    }
}
