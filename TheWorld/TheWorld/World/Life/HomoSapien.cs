using System;
using TheWorld.GlobalFunctions;

namespace TheWorld.World.Life
{
    /// <summary>
    ///     Human
    ///     https://en.wikipedia.org/wiki/Homo_sapiens
    /// </summary>
    class HomoSapien : Homo {

        private string _name;
        private int _height;
        private int _weight;

        public HomoSapien(string name) : this((Gender)EnumFunctions.GetRandomEnumElement(default(Gender)), DateTime.Now, name, IntegerFunctions.GetRandomInt(350, 500), IntegerFunctions.GetRandomInt(2000, 5000)) {

        }

        public HomoSapien(Gender sex, DateTime dateofBirth, string name, int height, int weight) : base(sex, dateofBirth) {
            _name = name;
            _height = height;
            _weight = weight;
        }

        public string Name{
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     Height kept in mm
        /// </summary>
        public int Height{
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        ///     Weight kept in grams
        /// </summary>
        public int Weight{
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
