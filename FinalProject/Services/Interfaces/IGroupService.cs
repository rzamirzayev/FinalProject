using FinalProject.Enums;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services.Interfaces
{
    internal interface IGroupService
    {
        public List<Group> Groups { get; }
        public string CreateGroup(GroupCategory groupCategory,int groupNumber,bool IsOnline);
        public void GetAllGroup();

        public string EditGroup(string no,int groupnumer);

        public void GetGroupStudents(string no);

        public void GetAllStudents();

        public string CreateStudent(string Name,string surname,string group,bool Type);




    }
}
