using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PimenovaTS.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] number)
        {
            var total = 0;
            for (var i = 0; i < number.Length; i++)
            {
                total = total + number[i];
            }
            return total;
        }

        public static object SubtractionArray(int[] number)
        {
            var total = 0;
            var index = 0;

            whule(index < number.Length);
            {
                total = total - number[index];
                index++;
            }
            return total;
        }

        public static object MultiplicationArray(int[] number)
        {
            var total = 1;
            var index = 0;

            do
            {
                total = total * number[index];
                index++;
            }
            while (index < number.Length);

            return total;
        }
}
