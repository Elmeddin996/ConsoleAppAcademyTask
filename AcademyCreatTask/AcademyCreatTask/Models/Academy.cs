using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCreatTask.Models
{
    internal static class Academy
    {
        public static List<AcademyGroups> Groups { get; set; }= new List<AcademyGroups>();
        public static List<Student> Students { get; set;  }= new List<Student>();
    }
}
