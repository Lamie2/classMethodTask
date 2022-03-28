using System;
using System.Collections.Generic;
using System.Text;

namespace StringMethods2
{
    class Group
    {
        public string No;
        public Student [] students;
        int j = 0;
        public void AddStudent(Student student)
        {
            if (StudentLimit<=students.Length)
            {
                students[j++] = student;
            }
        }
        public int StudentLimit;

        public void GetInfo()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"FullName ; {item.FullName} , " + $"GroupNo : {item.GroupNo} , AvgPoint : {item.AvgPoint} ");
            }

        }


        public void Search(string searchWord) {
            foreach (var item in students)
            {
                if(item.FullName.Contains(searchWord))
                 Console.WriteLine(item.FullName);
            }
        }

    }

}
