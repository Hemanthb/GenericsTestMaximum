using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class GenericCheckMaximumOfThree<T> where T:IComparable 
    {
        public T[] checkMaxArray;

        public GenericCheckMaximumOfThree(T[] valueArray)
        {
        this.checkMaxArray = valueArray;
        }

        public T[] SortArray(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T CheckMax(T[] maxArray)
        {
            var values = SortArray(maxArray);
            return values[values.Length - 1];

        }

        public T CheckMaximum()
        {
            T value = CheckMax(this.checkMaxArray);
            PrintMax(value);
            return value;
        }

        public void PrintMax(T value)
        {
            Console.WriteLine("Maximum value is ---> "+value);
        }
        
    }
}
