using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BaseExam
{
    internal class Program
        {
            private static void Main(string[] args)
            {
                // Создать один объект типа Student, преобразовать данные в текстовый вид с помощью метода ToShortString() и вывести данные.

                var student = new Student(new Person("Alexander ", "Truen ", new DateTime(2004, 06, 19)), Education.Вachelor, 320);
                Console.WriteLine(student.ToShortString());

                // Вывести значения индексатора для значений индекса Education.Specialist, Education.Bachelor и Education.SecondEducation.

                Console.WriteLine(student[Education.Specialist]);
                Console.WriteLine(student[Education.Вachelor]);
                Console.WriteLine(student[Education.SecondEducation]);
                // Присвоить значения всем определенным в типе Student свойствам, преобразовать данные в текстовый вид с помощью метода ToString() и вывести данные.

                student.Persons = new Person("Lewn ", "Truen ", new DateTime(2008, 09, 12));
                student.Educations = Education.Specialist;
                student.NumGroups = 320;

                Console.WriteLine(student.ToString());

                // C помощью метода AddExams( params Exam*+ ) добавить элементы в список экзаменов и вывести данные объекта Student, используя метод ToString().

                student.AddExams(new Exam("AOiP", 4, new DateTime(2022, 09, 25)), new Exam("PiTPM", 5, new DateTime(2022, 09, 27)));
                Console.WriteLine(student.ToString());

                //Сравнить время выполнения операций с элементами одномерного, двумерного прямоугольного и двумерного ступенчатого массивов с одинаковым числом элементов типа Exam.

                var OneArray = new Exam[10000];
                var TwoArray = new Exam[100,100];
                var jaggedArray = new Exam[100][];

                

                // Одномерный массив     
                var sw = Stopwatch.StartNew();

                for (int i = 0; i < 10000; i++)
                {
                    OneArray[i] = null;
                }
                    
                sw.Stop();
                Console.Write("Одномерный массив: ");
                Console.WriteLine(sw.Elapsed);

                // Двумерный массив
                sw = Stopwatch.StartNew();

                for(int i = 0; i < 100; i++)
                {
                    for(int j = 0; j < 100; j++)
                    {
                        TwoArray[i,j] = null;
                    }
                }

                sw.Stop();
                Console.Write("Двумерный прямоугольный массив: ");
                Console.WriteLine(sw.Elapsed);

                // Двумерный ступенчатый

                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    jaggedArray[i] = new Exam[1000];
                }

                sw = Stopwatch.StartNew();

                for(int i = 0; i < 100; i++)
                {
                    for(int j = 0; j < 100; j++)
                    {
                        jaggedArray[i][j] = null;
                    }
                }

                sw.Stop();
                Console.Write("Двумерный ступенчатый массив: ");
                Console.WriteLine(sw.Elapsed);
                Console.ReadKey();
            }
        }


    enum Education
    {
        Specialist,
        Вachelor,
        SecondEducation
    }
}
