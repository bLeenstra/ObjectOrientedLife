using System;

namespace TheWorld.World.Life
{
    public class LifeForm
    {
        private bool _alive;
        private readonly DateTime _dateOfBirth;

        internal LifeForm() : this(DateTime.Now){}

        internal LifeForm(DateTime dateofBirth){
            _alive = true;
            _dateOfBirth = dateofBirth;
        }

        public bool Alive {
            get { return _alive; }
            set { _alive = value; }
        }

        public DateTime DateOfBirth => _dateOfBirth;

        public int Age => GlobalFunctions.DateFunctions.YearsDifference(DateOfBirth, DateTime.Today);
    }
}
