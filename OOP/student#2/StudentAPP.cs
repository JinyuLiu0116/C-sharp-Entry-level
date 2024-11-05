using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class StudentAPP
    {
        static void Main(string[] args)
        {
            try
            {
                Student student1 = new Student();
                Student student2 = new Student("Jinyu", "Liu");
                Student student3 = new Student("Ikura", "Ayase", "CS", 3.975, 24236282);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: "+e.Message);
            }
        }
    }
}
