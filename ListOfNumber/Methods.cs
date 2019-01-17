using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNumber
{
    /// <summary>
    /// Класс, содержащий методы для работы с коллекциями чисел
    /// </summary>
    public static class Methods
    {
        /// <summary>
        /// Процедура сложения чисел
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static int Additional(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Процедура вычитания чисел
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static int Substruct(int a, int b)
        {
            return a - b;
        }

        private static void Sort()
        {

        }
    }
}
