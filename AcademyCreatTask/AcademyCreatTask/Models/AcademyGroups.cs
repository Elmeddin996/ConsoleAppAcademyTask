using AcademyCreatTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCreatTask.Models
{
    internal class AcademyGroups
    {
        static int _id = 100;
        public int Id { get; set; }
        public string No { get; set; }
        public bool IsOnline { get; set; } 
        public LessonCategorys Category { get; set; }

        public AcademyGroups(LessonCategorys category) 
        {
            No = $"{category.ToString().Substring(0,1)}{_id}";
            Category = category;
            IsOnline=false ;
            Id=_id;
            _id++;

        }
       
    }
}
