using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    class Examination
    {
        public int Semester { set; get; }
        public string Subject { set; get; }
        public string Teacher { set; get; }
        public int Points { set; get; }
        public bool IsExamination { set; get; }
        public DateTime Date { set; get; }
        public Examination()
        {
            Semester = 1;
            Subject = "Математический анализ";
            Teacher = "Боднарчук С.В.";
            Points = 100;
            IsExamination = true;
            Date = new DateTime(2017, 6, 13);
        }
        public Examination(int Sem, string Sub, string T, int P, bool IsE, DateTime D)
        {
            Semester = Sem;
            Subject = Sub;
            Teacher = T;
            Points = P;
            IsExamination = IsE;
            Date = D;
        }
        public override string ToString()
        {
            return $"Название предмета: {Subject}; Имя преподавателя: {Teacher}; Баллы: {Points}";
        }
    }
}
