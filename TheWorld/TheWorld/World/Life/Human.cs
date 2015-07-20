using System;

namespace TheWorld.World.Life
{
    class Human : Primate
    {
        private string _name;
        private int _height;
        private int _weight;

        public Human(DateTime dateofBirth, string name, int height, int weight) : base(dateofBirth){
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
