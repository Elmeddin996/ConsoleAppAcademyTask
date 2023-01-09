using AcademyCreatTask.Enums;
using AcademyCreatTask.Models;
using AcademyCreatTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AcademyCreatTask.Services.Implimentation
{
    internal class AcademyServices : IAcademyServices
    {

      public void CreatGroup(LessonCategorys categorys,int online)
        {
            if (online<0||online>2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Please choose valid value!!!");
            }
            else
            {
             AcademyGroups group =new AcademyGroups(categorys);

             Academy.Groups.Add(group);

             Console.WriteLine($"{group.No}  Succesly created");

                switch (online)
                {
                    case 1:
                        group.IsOnline = true;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("This Group is Online");
                        break;

                    case 2:
                        group.IsOnline = false;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("This Group is Offline");
                        break;
                }
            }

        }
      
      public void CreateStudent(string fullname, int type,LessonCategorys categorys)
      {

          if (fullname.Length<5 || type < 0 || type > 2)
          {
              Console.BackgroundColor = ConsoleColor.Red;
              Console.WriteLine("Please choose valid value!!!");
          }
            foreach (var group in Academy.Groups)
            {
               if (group.Category==categorys)
               {
                  if (group.IsOnline)
                  {
                      if (Academy.Students.Count<10)
                      {
                            OnlineGroup(fullname,type);
                      }
                      else
                      {
                      Console.BackgroundColor = ConsoleColor.Red;
                      Console.WriteLine("The Group is Full!!!");
                      }
                  }
                  else
                  {

                      if (Academy.Students.Count < 15)
                      {
                          OnlineGroup(fullname, type);
                      }
                      else
                      {
                       Console.BackgroundColor = ConsoleColor.Red;
                       Console.WriteLine("The Group is Full!!!");
                      }
                  }

               }

            }

          
      }


      public void EditGroup(string no, string newNo)
      {
            bool CheckNo=false;

            foreach (var group in Academy.Groups)
            {
                if (group.No.Trim().ToLower() == newNo.Trim().ToLower())
                {
                    CheckNo = true;
                    Console.WriteLine("The group with this name is already available");
                    return;
                }
            }
            foreach (var group in Academy.Groups)
            {
                if (group.No.Trim().ToLower() == no.Trim().ToLower() && CheckNo == false)
                {
                    group.No = newNo;
                }
                else
                {
                Console.WriteLine("Group with this name does not exist");
                }
            }
      }

      public void GetAllGroups()
      {
          foreach (AcademyGroups group in Academy.Groups)
          {
                Console.WriteLine($" No:{group.No}\t\n Category:{group.Category}");
                Console.WriteLine($" Group includes {Academy.Students.Count} Student");
          }
      }

      public void GetAllStudents()
      {
          foreach (Student student in Academy.Students)
          {
              Console.WriteLine(student);
          }
      }

      public void GetStudents(string no)
      {
            if (Academy.Groups.Count > 0)
            {
                foreach (var group in Academy.Groups)
                {
                    if (group.No.Trim().ToLower() == no.Trim().ToLower())
                    {
                        if (Academy.Students.Count == 0)
                        {
                            Console.WriteLine("There is none in this group");
                        }

                        foreach (var student in Academy.Students)
                        {
                            Console.WriteLine($"Student's Fullname: {student.FullName}\t\nStudent's Guaranteed Status: {student.Type}");
                        }
                       
                    }
                }
            }
        }

     
      private void OnlineGroup(string fullname,int type)
        {
            Student student = new Student(fullname);
            switch (type)
            {
                case 1:
                    student.Type = true;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("This Student has a guaranteed education");
                    break;

                case 2:
                    student.Type = false;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("This Student does not have a guaranteed education");
                    break;

            }

            Academy.Students.Add(student);
            
            

            Console.WriteLine($"{student.FullName} Succesly added");

        }
    }
}
