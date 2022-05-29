using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class GenericCheckMaximumOfThree<T> where T:IComparable 
    {
        public T first, second, third;

        public GenericCheckMaximumOfThree(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static T CheckMaximum(T first, T second,T third)
        {
            if(first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(first) > 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }

        public T CheckMaximum()
        {
            T value = GenericCheckMaximumOfThree<T>.CheckMaximum(this.first, this.second, this.third);
            return value;
        }
        
    }
}
