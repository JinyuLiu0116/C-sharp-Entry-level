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
        public StudentApp(string num, string first, string last, string year, string focus)
        {
            setStudentNum(num);
            setFirstName(first);
            setLasttName(last);
            setClassification(year);
            setMajor(focus);
        }

        public StudentApp(string first, string last)
        {
            setFirstName(first);
            setLasttName(last);
        }

        public StudentApp(string first, string last, string focus)
        {
            setFirstName(first);
            setLasttName(last);
            setMajor(focus);
        }
        public string getFirstName() { return this.firstName; }
        public string getLastName() { return this.lastName; }
        public string getStudentNum() { return this.studentNum; }
        public string getClassification() { return this.classification; }
        public string getMajor() { return this.major; }
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLasttName(string lastName) { this.lastName = lastName; }
        public void setStudentNum(string studentNum) { this.studentNum = studentNum; }
        public void setClassification(string classification) { this.classification = classification; }
        public void setMajor(string major) { this.major = major; }
        public string ReturnFullName()
        {
            return getFirstName() + " " + getLastName();
        }
        public override string ToString()
        {
            return "Student Number: " + getStudentNum() +
                "\nName: " + ReturnFullName() +
                "\nClassification: " + getClassification() +
                "\nMajor: " + getMajor();
        }
    }
}
