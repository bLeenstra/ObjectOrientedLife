using System;

namespace TheWorld.World
{
    public class LifeForm
    {
        public enum Gender {
            Male,
            Female,
            Asexual
        }
        private bool _alive;
        private readonly DateTime _dateOfBirth;
        private Gender _sex;

        public LifeForm() : this(DateTime.Now){}

        public LifeForm(DateTime dateofBirth){
            _alive = true;
            _dateOfBirth = dateofBirth;
        }

        public LifeForm(DateTime dateofBirth, Gender sex){
            _alive = true;
        }

        public bool Alive {
            get { return _alive; }
            set { _alive = value; }
        }

        public DateTime DateOfBirth => _dateOfBirth;

        public int Age => GlobalFunctions.DateFunctions.YearsDifference(DateOfBirth, DateTime.Today);

        public Gender Sex {
            get { return _sex; }
            set { _sex = value; }
        }
    }
}
