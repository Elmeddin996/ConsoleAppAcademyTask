
using AcademyCreatTask.Enums;
using AcademyCreatTask.Models;
using AcademyCreatTask.Services.Implimentation;

int ChooseOperation;

do
{
    Console.BackgroundColor = ConsoleColor.Black;
  
    Console.WriteLine("For Create Group Press to: 1");
    Console.WriteLine("------------------------------");
    Console.WriteLine("For Create Student Press to: 2");
    Console.WriteLine("------------------------------");
    Console.WriteLine("For Edit The Group Press to: 3");
    Console.WriteLine("------------------------------");
    Console.WriteLine("For View All Groups Press to 4");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("For View Students in Group Press to 5");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("For View All Students Press to: 6");  
    Console.WriteLine("--------------------------------");
    Console.WriteLine("For Exit Press to: 0");
    int.TryParse(Console.ReadLine(),out ChooseOperation);

    switch (ChooseOperation)
    {
        case 1:
            AcademyMenuServices.CreateGroupMenu();
            break;
        case 2:
                AcademyMenuServices.CreateStudentMenu();
            break;
        case 3:
            AcademyMenuServices.EditGroupMenu();
            break;
        case 4:
                AcademyMenuServices.GetAllGroupsMenu();
            break;
        case 5:
                AcademyMenuServices.GetStudentsMenu();
            break;
        case 6:
            AcademyMenuServices.GetAllStudentsMenu();
            break;
        case 0:
            return;
        default:
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Please choose valid value!!!");
            break;
    }

} while (ChooseOperation!=0);

