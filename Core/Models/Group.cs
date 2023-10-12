using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Group
    {
        
        private byte _studentLimit;
        private string _no;

        public string No
        {
            get { return _no; }
            set
            {
                if (IsValidGroupNo(value))
                {
                    _no = value;
                }
                else
                {
                    Console.WriteLine("qrup nomresi yanlis  formatda daxil edilib ");
                }
            }
        }

        private bool IsValidGroupNo(string groupNo)
        {
            if (groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
            {
                if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                {
                    return true;
                }
            }
            return false;
        }


        public Student[] Students = Array.Empty<Student>();


        public Group(string no,byte studentLimit)
        {
            this.No = no;
            this._studentLimit = studentLimit;
        }

        public byte StudentLimit
        {
            get 
            {
                return _studentLimit; 
            }
            set 
            {
                if (value>0 && value<=20)
                {
                    _studentLimit = value;
                }
            }
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length+1);
            if (Students.Length < StudentLimit ) 
            {
                Students[^1] = student;
            }
            else { Console.WriteLine("Telebe limiti asildi"); }
        }
    }
}
