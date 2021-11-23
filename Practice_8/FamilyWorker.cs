using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8
{
    class FamilyWorker : Worker, ICloneable, IPerson, ICompare
    {
        public FamilyWorker(string firstname, string secondname, string patronymic) : base(firstname, secondname, patronymic)
        {
            FirstName = firstname;
            SecondName = secondname;
            Patronymic = patronymic;
        }

        public bool CompareTo(object worker)
        {
            FamilyWorker firstworker = (FamilyWorker)worker;
            if (SecondName == firstworker.SecondName) return true;
            else
                return false;
        }

        public FamilyWorker ShallowClone()
        {
            return (FamilyWorker)this.MemberwiseClone();
        }

        public object Clone()
        {
            return new FamilyWorker(FirstName, SecondName, Patronymic);
        }

        public string ShowInfoOfFamilyWorker()
        {
            return ShowInfoOfWorker();
        }
    }
}
