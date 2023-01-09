using FinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    internal class Group
    {
        public GroupCategory Category { get; set; }
        
        
        public string No { get; set; }
        public int GroupNumber { get; set; }

        public bool IsOnline { get; set; }
        public List<Student> students=new List<Student>();
        

        public Group(GroupCategory category,int groupnumber,bool isonline)
        {
            this.No = $"{category.ToString().Substring(0,1)}{groupnumber}";
            this.Category = category;
            this.GroupNumber = groupnumber;
            this.IsOnline = isonline;
            
           
            
        }
        public override string ToString()
        {
            return $"{No} Category:{Category} IsOnline:{IsOnline} Number:{students.Count}";
        }



    }
}
