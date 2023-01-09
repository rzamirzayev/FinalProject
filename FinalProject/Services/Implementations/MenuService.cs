using FinalProject.Enums;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services.Implementations
{
    internal class MenuService
    {
        private static GroupService GroupService=new GroupService();
        public static void CreateGroupMenu()
        {
            
            test:
            Console.WriteLine("Hansi kategoriyani secmek istiyirsiniz:");
            foreach(var item in Enum.GetValues( typeof( GroupCategory ) ) )
            {
            
             Console.WriteLine($"{(int)item}.{item}");
            }   
            int CategoryLength=Enum.GetValues( typeof( GroupCategory ) ).Length;
            int.TryParse( Console.ReadLine(), out  int CategoryNumber );
            if(CategoryNumber<=0 || CategoryNumber>CategoryLength)
            {
                goto test; 
            }
            Console.WriteLine("Group nomresini daxil edin");
            int.TryParse(Console.ReadLine(), out int group);
            Console.WriteLine("    ");
            test2:
            Console.WriteLine("Group Online yoxsa Offline olacaq?");
            Console.WriteLine("Online ucun:On");
            Console.WriteLine("Offline ucun Off daxil edin");
            string type;
            bool isonline;
            type= Console.ReadLine();
            if (type.ToLower().Trim() == "on")
            {
                isonline = true;
            }
            else if (type.ToLower().Trim()== "off")
            {
                isonline=false;
            }
            else
            {
                goto test2;
            }
            
            GroupService.CreateGroup((GroupCategory)CategoryNumber, group, isonline);
        }
        public static void GetAllGroupMenu()
        {
            GroupService.GetAllGroup();
        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("Hansi groupun nomresini deyismek istediyinizi daxil edin:");
            string groupname;
            groupname = Console.ReadLine();
            test3:
            Console.WriteLine("    ");
            Console.WriteLine("Groupun yeni nomresini daxil edin:");
            int.TryParse(Console.ReadLine(), out int groupnumber);
            if (groupnumber <= 0)
            {
                goto test3;
            }
            GroupService.EditGroup(groupname, groupnumber);
        }
        public static void GetGroupStudentsMenu()
        {
            Console.WriteLine("Hansi groupun studentlerini gormek istiyirsiniz");
            string groupname = Console.ReadLine(); ;
            GroupService.GetGroupStudents(groupname.ToLower());
        }
        public static void GetAllStudentsMenu()
        {
            GroupService.GetAllStudents();
        }
        public static void CreateStudentMenu()
        {
            Console.WriteLine("Adinizi daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin:");
            string surname=Console.ReadLine();
            Console.WriteLine("Groupunuzu daxil edin:");
            string group=Console.ReadLine();
            Console.WriteLine("Telebe zemanetli yoxsa zemanetizdir?");
            test4:
            Console.WriteLine("Eger Zemanetlidirse Y,Zemanetli deyilse N daxil edin.");
            
            string type;
            type=Console.ReadLine();
            bool typebool;
            if (type == "Y")
            {
                typebool= true;
            }
            else if(type== "N")
            {
                typebool= false;
            }
            else
            {
                goto test4;

            }
            GroupService.CreateStudent(name, surname,group.ToLower(),typebool);

            

        }
    }

}
