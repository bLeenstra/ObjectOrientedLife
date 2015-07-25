using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.World.Life {
    /// <summary>
    ///     https://en.wikipedia.org/wiki/Theria
    ///     the of mammals that give birth through pregnancy rather than eggs
    /// </summary>
    class Theria : Mammalia
    {

        private bool _pregnant;

        internal Theria(DateTime dateofBirth) : base(dateofBirth) {

        }

        /// <summary>
        ///     
        /// </summary>
        public bool Pregnant{
            get { return _pregnant; }
            set{ _pregnant = value; }
        }
    }
}
