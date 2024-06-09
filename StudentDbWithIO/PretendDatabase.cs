using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbWithIO
{
    internal class PretendDatabase
    {
        public void PopulateStudent(int numberToDefine)
        {
            string[] students = new string[numberToDefine];
            for (int i = 0; i < students.Length; i++)
            {
                Student student = new Student();
                student.StudentId = i;
                student.StudentName = "SmartyPants-" + i;
                student.StudentFaveFood = "ObscureFood-" + i;
                student.StudentHomeTown = "Funkytown-" + i;
            }
        }
    }
}
