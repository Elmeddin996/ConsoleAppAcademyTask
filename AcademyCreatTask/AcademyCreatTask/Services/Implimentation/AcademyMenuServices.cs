using AcademyCreatTask.Enums;
using AcademyCreatTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCreatTask.Services.Implimentation
{
    internal class AcademyMenuServices
    {
        private static AcademyServices Academy = new();

        public static void CreateGroupMenu()
        {
            Console.WriteLine("If you want to create an Online group, press: 1");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("If you want to create an Offline group, press: 2");
            int.TryParse(Console.ReadLine(), out int online);
            TryAgain:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("    ");
            Console.WriteLine("Please Choose Category");
            Console.WriteLine("    ");

            foreach (var item in Enum.GetValues(typeof(LessonCategorys)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }

            int CategoryLength = Enum.GetValues(typeof(LessonCategorys)).Length;


            int.TryParse(Console.ReadLine(), out int CategoryNumber);


            if (CategoryNumber <= 0 || CategoryNumber > CategoryLength)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Please choose valid value!!!");
                goto TryAgain;
            }

          Academy.CreatGroup((LessonCategorys)CategoryNumber,online);
        }
        public static void CreateStudentMenu() 
        {
            Console.WriteLine("Enter Student's Full Name");
            string FullName=Console.ReadLine();

            Console.WriteLine("If you want to create guaranteed student press: 1");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("If you want to create non-guaranteed student press: 2");
            int.TryParse(Console.ReadLine(), out int type);

            TryAgain:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("    ");
            Console.WriteLine("Please Choose Category");
            Console.WriteLine("    ");

            foreach (var item in Enum.GetValues(typeof(LessonCategorys)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }

            int CategoryLength = Enum.GetValues(typeof(LessonCategorys)).Length;


            int.TryParse(Console.ReadLine(), out int CategoryNumber);


            if (CategoryNumber <= 0 || CategoryNumber > CategoryLength)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Please choose valid value!!!");
                goto TryAgain;
            }


            Academy.CreateStudent(FullName,type,(LessonCategorys)CategoryNumber);
        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("Enter the number of the group you want to edit");
            string No=Console.ReadLine();
            Console.WriteLine("Enter a new group number");
            string NewNo=Console.ReadLine();
            Academy.EditGroup(No,NewNo);
        }

        public static void GetAllGroupsMenu()
        { 
            Academy.GetAllGroups();
        }

        public static void GetStudentsMenu()
        {
            Console.WriteLine("Enter the group number");
            string No=Console.ReadLine();   
            Academy.GetStudents(No);
        }

        public static void GetAllStudentsMenu()
        {
            Academy.GetAllStudents();
        }


    }
}
