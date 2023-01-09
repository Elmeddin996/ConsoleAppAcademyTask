using AcademyCreatTask.Enums;
using AcademyCreatTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AcademyCreatTask.Services.Interfaces
{
    internal interface IAcademyServices
    {
       
        public void CreatGroup(LessonCategorys categorys, int online);
        public void EditGroup(string no, string newNo);
        public void CreateStudent(string fullname,int type,LessonCategorys categorys);
        public void GetStudents(string no);
        public void GetAllGroups();
        public void GetAllStudents();

    }
}
