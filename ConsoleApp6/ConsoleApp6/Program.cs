using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            student[] student1 = new student [] {new student("Михаил", "Одожий", "ПКС-320", 4.6), 
            new Aspirant ("Михаил", "Одожий", "ПКС-320", 5)};
            foreach (var student in student1)
            {
                Console.WriteLine("Имя:" + student.FName + "," + "Фамилия:" + student.LName + "," +
                "Группа:" + student.Group + "," + "Средняя оценка" + student.AvarageMark + "," + "Степендия:" +
                student.getSshcolarship());
            }

        }

     
    }
}
