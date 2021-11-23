using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8
{
    class Worker
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }

        public Worker(string firstname, string secondname, string patronymic)
        {
            FirstName = firstname;
            SecondName = secondname;
            Patronymic = patronymic;
        }

        public string ShowInfoOfWorker()
        {
            return $"{FirstName} {SecondName} {Patronymic}";
        }
    }
}
