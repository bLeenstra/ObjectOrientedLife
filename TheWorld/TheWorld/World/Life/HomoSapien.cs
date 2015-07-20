using System;

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

        public HomoSapien(DateTime dateofBirth, string name, int height, int weight) : base() {
            _name = name;
            _height = height;
            _weight = weight;
        }

        public string Name{
            get { return _name; }
            set { _name = value; }
        }

        public int Height{
            get { return _height; }
            set { _height = value; }
        }

        public int Weight{
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
