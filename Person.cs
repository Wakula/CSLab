using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Year
        {
            get
            {
                return BirthDate.Year;
            }

            set
            {
                BirthDate = new DateTime(value, BirthDate.Month, BirthDate.Day);
            }
        }
        public virtual void PrintFullInfo()
        {
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Дата рождения: {BirthDate.ToShortDateString()}");
        }
        public Person()
        {
            FirstName = "Николай";
            LastName = "Борунов";
            BirthDate = new DateTime(2019, 1, 1);
        }
        public Person(string FName, string LName, DateTime BDate)
        {
            FirstName = FName;
            LastName = LName;
            BirthDate = BDate;
        }
    }
}
