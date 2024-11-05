using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Student
{
    internal class Student
    {
        private string studentFirstName;
        private string studentLastName;
        private string studentFullName;
        private string studentEmail;
        private string studentMajor;
        private double studentGPA;
        private int studentID;

        public Student() {
            this.studentFirstName = "Unknown";
            this.studentLastName = "Unknown";
            this.studentFullName = "Unknown";
            this.studentEmail = "Unknown";
            this.studentMajor = "Unknown";
            this.studentGPA = 0.0;
            this.studentID = 0;
        }
        public Student(in string firstName, in string lastName)
        {
            this.setFirstName(firstName);
            this.setLastName(lastName);
            this.setFullName(this.getFirstName(), this.getLastName());
            this.setEmail(this.getFirstName(), this.getLastName());
            this.studentMajor = "Unknown";
            this.studentGPA = 0.0;
            this.studentID = 0;

        }
        public Student(in string firstName, in string lastName, in string major, in double GPA, in int id)
        {
            this.setFirstName(firstName);
            this.setLastName(lastName);
            this.setFullName(this.getFirstName(), this.getLastName());
            this.setEmail(this.getFirstName(), this.getLastName());
            this.StudentMajor = major;
            this.StudentGPA = GPA;
            this.StudentID = id;
        }

        public string getFirstName() { return this.studentFirstName; }
        public string getLastName() { return this.studentLastName; }
        public string getFullName() { return this.studentFullName; }
        public string getEmail() { return this.studentEmail; }
        public void setFirstName(in string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new Exception("Empty input value");
            }
            else if (!firstName.All(char.IsLetter))
            {
                throw new Exception("Invalid input value");
            }
            else
            {
                this.studentFirstName = firstName;
            }
        }
        public void setLastName(in string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new Exception("Empty input value");
            }
            else if (!lastName.All(char.IsLetter))
            {
                throw new Exception("Invalid input value");
            }
            else
            {
                this.studentLastName = lastName;
            }
        }
        public void setFullName(in string firstName, in string lastName)
        {
            this.studentFirstName = firstName+" "+lastName;
        }
        public void setEmail(in string firstName, in string lastName)
        {
            this.studentEmail = firstName + "." + lastName + "@school.com";
        }
        public string StudentMajor
        {
            get
            {
                return this.studentMajor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Empty input value");
                }
                else if (!value.All(char.IsLetter))
                {
                    throw new Exception("Invalid input value");
                }
                else
                {
                    this.studentLastName = value;
                }
            }
        }
        public double StudentGPA
        {
            get
            {
                return this.studentGPA;
            }
            set
            {
                if(value < 0.0 || value >4.0)
                {
                    throw new Exception("Value out of range");
                }
                else
                {
                    this.studentGPA = value;
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
                    throw new Exception("Nagetive value");
                }
                else if (Convert.ToString(value).Length != 7)
                {
                    throw new Exception("Student ID must be 7 digits");
                }
                else
                {
                    this.studentID = value;
                }
            }
        }
    }
}

