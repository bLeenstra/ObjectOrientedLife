using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.World {
    class Mammal : LifeForm
    {

        private bool _pregnant;
        
        public Mammal(DateTime dateofBirth, Gender sex) :base(dateofBirth, sex){
            _pregnant = false;
        }

        public bool Pregnant {
            get { return _pregnant;}
            set {
                if( Sex == Gender.Female ){
                    _pregnant = value;
                }
            }
        }

    }
}
