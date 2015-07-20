using System;

namespace TheWorld.World.Life {
    class Primate : LifeForm
    {

        private bool _pregnant;

        public Primate() : this(DateTime.Now){}

        public Primate(DateTime dateofBirth) :base(dateofBirth){
            _pregnant = false;
        }

        public bool Pregnant {
            get { return _pregnant;}
            set {
                    _pregnant = value;
            }
        }

    }
}
