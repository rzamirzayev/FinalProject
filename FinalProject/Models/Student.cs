using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    internal class Student
    {
        public string FullName;
        public string group;
        public bool Type;
        public Student(string name,string surname,string group) 
        {
            FullName= $"{name} {surname}";
            this.group = group ;
            
        
        }
        public override string ToString()
        {
            return $"{FullName} Group:{group}";
        }
    }
}
