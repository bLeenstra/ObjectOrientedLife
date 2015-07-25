using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.GlobalFunctions;

namespace TheWorld.World.Life {
    class HomoHeidelbergensis : Homo
    {

        public HomoHeidelbergensis() : this((Gender)EnumFunctions.GetRandomEnumElement(default(Gender)), DateTime.Now){}

        public HomoHeidelbergensis(Gender sex, DateTime dateofBirth) : base(sex, dateofBirth) {

        }
    }
}
