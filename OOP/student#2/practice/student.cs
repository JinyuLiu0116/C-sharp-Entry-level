using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentPractice
{
    internal class Student
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private string major;
        private double gpa;
        private int studentID;

        public Student()
        {
            this.firstName = "Unknown";
            this.lastName = "Unknown";
            this.fullName = "Unknown";
            this.major = "Unknown";
            this.gpa = 0.0;
            this.studentID = 00000000;
        }
        public Student(in string first, in string last)
        {
            this.setFirstName(first);
            this.setLastName(last);
            this.fullName = first + " " + last;
            this.major = "Unknown";
            this.gpa = 0.0;
            this.studentID = 00000000;
        }
        public Student(in string first, in string last, in string major, in double gpa, in int id)
        {
            this.setFirstName(first);
            this.setLastName(last);
            this.fullName = first + " " + last;
            this.Major = major;
            this.Gpa = gpa;
            this.StudentID = id;
        }
        public string getFirstName() { return this.firstName; }
        public string getLastName() { return this.lastName; }
        public string getFullName() { return this.fullName; }
        public void setFirstName(in string first)
        {
            if (string.IsNullOrEmpty(first))
            {
                throw new Exception("Empty first name");
            }
            else if (!first.All(char.IsLetter))
            {
                throw new Exception("Contain invalid charactor");
            }
            else
            {
                this.firstName = first;
            }
        }
        public void setLastName(in string last)
        {
            if (string.IsNullOrEmpty(last))
            {
                throw new Exception("Empty first name");
            }
            else if (!last.All(char.IsLetter))
            {
                throw new Exception("Contain invalid charactor");
            }
            else
            {
                this.lastName = last;
            }

        }
        public string Major
        {
            get
            {
                return this.major;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Empty first name");
                }
                else if (!value.All(char.IsLetter))
                {
                    throw new Exception("Contain invalid charactor");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public double Gpa
        {
            get
            {
                return this.gpa;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Negative GPA");
                }
                else if (value > 4)
                {
                    throw new Exception("Out of range");
                }
                else
                {
                    this.gpa = value;
                }
            }
        }
        public int StudentID
        {
            get
            {
                return this.studentID;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Negative number");
                }
                else if (Convert.ToString(value).Length > 8) {
                    throw new Exception("ID must have 8 digit");
                }
                else
                {
                    this.studentID = value; 
                }
            }
        }
        public override string ToString()
        {
            return "Student Name:" + this.getFullName() +
                "Student Major:" + this.Major +
                "Student ID:" + this.StudentID +
                "Student GPA:" + this.Gpa;
        }

    }
}

