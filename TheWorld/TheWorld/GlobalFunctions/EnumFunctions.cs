using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.GlobalFunctions {
    static class EnumFunctions {

        public static int GetRandomEnumElement(Enum type){
            Array values = Enum.GetValues(type.GetType());
            return IntegerFunctions.GetRandomInt(0, values.Length);
        }
    }
}
