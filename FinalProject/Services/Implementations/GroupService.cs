using FinalProject.Enums;
using FinalProject.Models;
using FinalProject.Services.Interfaces;
using System.Net.Http.Headers;

namespace FinalProject.Services.Implementations
{

    internal class GroupService : IGroupService
    {
        private List<Group> _group { get; set; } = new List<Group>();
        public List<Group> Groups { get { return _group; } }





        public string CreateGroup(GroupCategory groupCategory, int groupNumber, bool IsOnline)
        {
            if (groupNumber <= 0)
            {
                Console.WriteLine("Group nomresi 0-dan kicik ola bilmez");
                return "";
            }
            else if (IsOnline == false)
            {
                
                Console.WriteLine("Group telebe sayi limiti 10 neferdir");
            }
            else if (IsOnline == true)
            {
                
                Console.WriteLine("Group telebe sayi limiti 15 neferdir");
            }
            Group group = new Group(groupCategory, groupNumber,IsOnline);
            Groups.Add(group);

            Console.WriteLine($"{group.No} ugurla yaradildi");
            return "";
            

        }

        public void GetAllGroup()
        {
            foreach (Group group in Groups)
            {
                Console.WriteLine(group);
            }
        }

        public string EditGroup(string no, int groupnumber)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    foreach (Group group2 in Groups)
                    {
                        if (group2.GroupNumber == groupnumber)
                        {
                            Console.WriteLine("Bu adda qrup movcuddur");
                            return " ";
                        }
                        else
                        {
                            group.GroupNumber = groupnumber;
                            group.No = $"{group.Category.ToString().Substring(0, 1)}{groupnumber}";
                            Console.WriteLine($"{no} groupu adi {group.No} ile evez olundu");
                            return "";

                        }
                    }
                }
                    
                   
                
            }
            Console.WriteLine("Duzgun group daxil edin");
            return "";
        }

        public void GetGroupStudents(string no)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    
                    foreach (Student student in group.students)
                    {

                        
                        Console.WriteLine(student);
                        
                    }
                    
                    return;  
                  
                  
                }
                
                
                    
                
            }
            Console.WriteLine("Duzgun group daxil elemediz");

        }

        public void GetAllStudents()
        {
            for(int i=0;i<Groups.Count;i++)
            {
                foreach(Student student in Groups[i].students)
                {
                    Console.WriteLine(student);
                }
                
            }
            

            

        }

       

        public string CreateStudent(string name, string surname, string group, bool Type)
        {
            bool b1 = string.IsNullOrEmpty(name);
            bool b2 = string.IsNullOrEmpty(surname);
            if (b1 == true || b2 == true)
            {
                Console.WriteLine("Adinizi veya Soyadinizi duzgun daxil edin");
                return " ";
            }
            else 
            {
                Student student= new Student(name, surname, group);

                foreach (Group item in Groups)
                {
                    if (item.No.ToLower() ==  group.ToLower().Trim())
                    {
                        if (item.IsOnline == true)
                        {
                            if (item.students.Count < 15)
                            {
                                item.students.Add(student);
                            }
                            else
                            {
                                Console.WriteLine("Qrup doludur");
                            }
                        }
                        else
                        {
                            if(item.students.Count < 10)
                            {
                                item.students.Add(student);
                            }
                            else
                            {
                                Console.WriteLine("Qrup doludur");
                            }
                        }

                        Console.WriteLine($"{student.FullName} Group:{group} Zemanet:{Type}");
                        return "";
                    }
                    else
                    {
                        Console.WriteLine("Bele bir qrup yoxdur");
                           
                    }
                   
                }
                return "";
               


            }
            
        }



    }
}


