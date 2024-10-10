using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execrise
{
    internal class StudentApp
    {
        private string studentNum;
        private string firstName;
        private string lastName;
        private string classification;
        private string major;

        // Default constructor
        public StudentApp()
        {
            this.studentNum = "Unknown";
            this.firstName = "Unknown";
            this.lastName = "Unknown";
            this.classification = "Unknown";
            this.major = "Unknown";
        }

        // Constructor used to create Student object
        public StudentApp(in string num, in string first, in string last, in string year, in string focus)
        {
            setStudentNum(num);
            setFirstName(first);
            setLasttName(last);
            setClassification(year);
            setMajor(focus);
        }

        public StudentApp(in string first, in string last)
        {
            setFirstName(first);
            setLasttName(last);
        }

        public StudentApp(in string first, in string last, in string focus)
        {
            setFirstName(first);
            setLasttName(last);
            setMajor(focus);
        }
        public string getFirstName { get{return this.firstName;} }
        public string getLastName { get{return this.lastName;} }
        public string getStudentNum { get{return this.studentNum;} }
        public string getClassification { get{return this.classification;} }
        public string getMajor { get{return this.major;} }
        public void setFirstName(in string firstName) { this.firstName = firstName; }
        public void setLasttName(in string lastName) { this.lastName = lastName; }
        public void setStudentNum(in string studentNum) { this.studentNum = studentNum; }
        public void setClassification(in string classification) { this.classification = classification; }
        public void setMajor(in string major) { this.major = major; }
        public string ReturnFullName()
        {
            return getFirstName + " " + getLastName;
        }
        public override string ToString()
        {
            return "Student Number: " + getStudentNum +
                "\nName: " + ReturnFullName() +
                "\nClassification: " + getClassification +
                "\nMajor: " + getMajor;
        }
    }
}
