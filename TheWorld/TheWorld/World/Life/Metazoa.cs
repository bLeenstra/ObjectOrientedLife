using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.World.Life {
    /// <summary>
    ///     Animal
    ///     https://en.wikipedia.org/wiki/Animal
    /// </summary>
    class Metazoa : Opisthokont {

        public enum Gender {
            Male,
            Female
        }

        private Gender _sex;

        internal Metazoa(Gender sex, DateTime dateofBirth) : base(dateofBirth){
            _sex = sex;
        }

        public Gender Sex {
            get { return _sex; }
            set { _sex = value; }
        }
    }
}
