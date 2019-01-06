using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    class Student : Person, ICloneable
    {
        public enum Education
        {
            Master,
            Bachelor,
            SecondEducation,
            PhD
        }
        public Education Qualification { get; set; }
        public string Group { get; set; }
        private int bookNum;
        public int BookNum 
        {
            get
            {
                return bookNum;
            }
            set
            {
                if (value <= 99999 || value > 99999999)
                {
                    throw new Exception("Допустимы значения от 100000 до 99999999");
                }
                bookNum = value;
            }
        }
        public List<Examination> Exams = new List<Examination>();
        public double Average
        {
            get
            {
                int sum = 0;
                foreach (Examination ex in Exams)
                {
                    sum += ex.Points;
                }
                return (double)sum / Exams.Count;
            }
        }
        public void AddExams(Examination[] examList)
        {
            Exams.AddRange(examList);
        }
        public override string ToString()
        {
            return $"Имя: {FirstName}; Фамилия: {LastName}; Группа: {Group}";
        }
        public override void PrintFullInfo()
        {
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Дата рождения: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Образование: {Qualification}");
            Console.WriteLine($"Группа: {Group}");
            Console.WriteLine($"Номер зачетной книги: {BookNum}");
            if (Exams.Count == 0)
            {
                Console.WriteLine("Отсутствуют сданные экзамены.");
            }
            else
            {
                Console.WriteLine("Список сданных экзаменов:");
                foreach (Examination ex in Exams)
                {
                    Console.WriteLine(ex);
                }
            }
            Console.WriteLine($"Средний балл: {Average}");
        }
        public object Clone()
        {
            Student Tmp = new Student
            {
                FirstName = FirstName,
                LastName = LastName,
                BirthDate = BirthDate,
                Qualification = Qualification,
                BookNum = BookNum,
                Group = Group
            };
            foreach (Examination ex in Exams)
            {
                Tmp.Exams.Add(ex);
            }
            return Tmp;
        }
        public System.Collections.IEnumerable GetCredits()
        {
            foreach (Examination ex in Exams)
            {
                if (!ex.IsExamination)
                {
                    yield return ex;
                }
            }
            yield break;
        }
        public Examination[] GetSortedExams()
        {
            return Exams.OrderBy(exam => exam.Subject).ToArray();
        }
    }
}
