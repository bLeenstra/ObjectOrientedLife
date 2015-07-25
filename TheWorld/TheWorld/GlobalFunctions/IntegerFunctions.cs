using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.GlobalFunctions {
    static class IntegerFunctions {

        public static int GetRandomInt(int startValue, int endValue){
            Random rng = new Random();
            return rng.Next(startValue, endValue);
        }
    }
}
