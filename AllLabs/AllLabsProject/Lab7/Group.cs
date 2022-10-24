using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    public class Group
    {
        public void AddStudent(List<Student> students)
        {
            students = _students;
        }
        private static List<Student> _students = new List<Student>();

        public static void AddStudent()
        {
            _students.Add(new Student());
            AddStudentInfo();
        }
        private static void AddStudentInfo()
        {
            foreach (Student student in _students)
            {
                Console.WriteLine("Введите имя студента");
                student.Name = Console.ReadLine();
                Console.WriteLine("Введите пол студента");
                student.Gender = Console.ReadLine();
                Console.WriteLine("Введите возраст студента");
                student.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ВУЗ/ССУЗ студента");
                student.Institution = Console.ReadLine();
                Console.WriteLine("Введите специальность студента");
                student.Specialization = Console.ReadLine();
                Console.WriteLine("Введите группу студента");
                student.Group = Console.ReadLine();
            }


        }
        public static int StudentCount()
        {
            int count = 0;
            foreach (Student student in _students)
            {
                count++;
            }

            return count;
        }
        public static string StudentsInfo()
        {
            foreach (Student student in _students)
            {
                return ($"Имя: {student.Name}, Пол: {student.Gender}, Возраст: {student.Age}, ВУЗ/ССУЗ: {student.Institution}, Специальность: {student.Specialization} Группа: {student.Group}");
            }
            return "Я ХЗ";

        }
    }
}
