using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                FirstName = "Женя",
                LastName = "Ковач",
                BirthDate = new DateTime(2000, 4, 4),
                Group = "ИК-45",
                BookNum = 100000,
                Qualification = Student.Education.Bachelor
            };
            Console.WriteLine(student);
            Console.WriteLine();
            Examination[] exams = { new Examination(), new Examination(1, "Философия", "Куцык", 95, false, new DateTime(2018, 12, 25))};
            student.AddExams(exams);
            Console.WriteLine(student);
            Console.WriteLine();
            student.PrintFullInfo();
            Console.WriteLine();
            Console.WriteLine("Задание 1");
            Student student1 = (Student)student.Clone();
            student1.PrintFullInfo();
            Console.WriteLine();
            Console.WriteLine("Задание 9");
            foreach (Examination ex in student.GetCredits())
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine();
            Console.WriteLine("Задание 12");
            Examination[] sorted = student.GetSortedExams();
            foreach (Examination ex in sorted)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            student.BookNum = 0;
            student.BookNum = 100000000;
            Console.ReadKey();
        }
    }
}
