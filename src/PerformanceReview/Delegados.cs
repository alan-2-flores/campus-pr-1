using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReview
{
    public class Delegados
    {
        public Func<int,int,int> suma=(a,b)=>a+b;
        public Func<int,int,int> resta=(a,b)=>a-b;
        //public Action<float, float> zeroException = (a, b) =>
        //{
        //    try
        //    {
        //        float division = a / b;
        //        division=division*division;
        //    }
        //    catch (DivideByZeroException message)
        //    {
        //        throw message;
        //    }
        //};

    }
}
