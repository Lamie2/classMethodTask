using System;

namespace StringMethods2
{
    class Program
    {
        static void Main(string[] args)
        {

            string groupNo = null;
            int studentLimit = 0;
            bool enterGroupNo = true;
            string enterGropuNoMessage = "Zehmet olmasa Grup Nomresini daxil edin";

            while (enterGroupNo) 
            {
                Console.WriteLine(enterGropuNoMessage);
                groupNo = Console.ReadLine();
                if (CheckNo(groupNo))
                {
                    enterGroupNo = false;
                }
                else {
                    enterGropuNoMessage = "No dəyəri 2 böyük hərflə başlamalı və sonrasında 3 rəqəm olmalıdır";
                }
            }

           
            bool enterStudentLimit = true;
            string enterStudentLimitMessage = "Zehmet olmasa student limitini daxil edin : ";
            while (enterStudentLimit)
            {
                Console.WriteLine(enterStudentLimitMessage);
                studentLimit = int.Parse(Console.ReadLine());
                if (studentLimit >= 0 || studentLimit <= 20)
                {
                    enterStudentLimit = false;
                }
                else {
                    enterStudentLimitMessage = "Limit nomresi 0 ve 20 arasinda olmalidir.";
                }
            }

            Group group = new Group();

            bool runProgram = true;
            do
            {
                Console.WriteLine($"1. Tələbə əlavə et");
                Console.WriteLine($"2. Bütün tələbələrə bax");
                Console.WriteLine($"3. Tələbələr üzrə axtarış et");
                Console.WriteLine($"0. Proqramı bitir");


                Console.WriteLine($"Zehmet olmasa sechiminizi edin");
                int answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 0:
                        runProgram = false;
                        break;
                    case 1:
                        Console.WriteLine("FullName: ");
                        string fullName = Console.ReadLine();
                        Student student1 = new Student(fullName);
                        Console.WriteLine("GroupNo: ");
                        student1.GroupNo = Console.ReadLine();
                        Console.WriteLine("AvgPoint: ");
                        student1.AvgPoint = double.Parse(Console.ReadLine());
                        group.AddStudent(student1);
                        break;
                    case 2:
                        group.GetInfo();
                        break;
                    case 3:
                        Console.WriteLine("Axtarilacaq sozu daxil edin.");
                        string SearchingValue = Console.ReadLine();
                        group.Search(SearchingValue);
                        break;
                    default:
                        runProgram = false;
                        break;
                }
            }
            while (runProgram);

            

            
        }
        

        static bool CheckNo(string GroupNo)
        {

            if (GroupNo.Length >= 4)
            {
                if (char.IsLetter(GroupNo[0]) && char.IsLetter(GroupNo[1]) && char.IsDigit(GroupNo[GroupNo.Length - 1]) 
                    && char.IsDigit(GroupNo[GroupNo.Length - 2]) && char.IsDigit(GroupNo[GroupNo.Length - 3]))
                {
                    return true;
                }
                else
                {
                    return false;
                }   
            }
            else 
            { 
                return false;
            }
           
        }
            
                
        
    }
}
