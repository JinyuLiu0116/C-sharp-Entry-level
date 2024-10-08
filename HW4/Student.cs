using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Student_class
{
    /*
Create a class representing a student. Include characteristics such as
student number, first and last name, classification, and major. Write at
least two constructors. Include properties for each of the data items except Major which should have old-fashion getter/setter.
Include an instance method that returns a full name (with a space
between first and last name).
     */
    internal class Program
    {
        internal class Student
        {
            private string firstName;
            private string lastName;
            private string classification;
            private string major;
            
            public Student()
            {
                setFirstName("Unknown");
                setLastName("Unknown");
                setClassification("Unknown");
                setMajor("Unknown");
            }
            public Student(string firstName, string lastName)
            {
                setFirstName(firstName);
                setLastName(lastName);
                setClassification("Unknown");
                setMajor("Unknown");
            }
            public Student(string firstName, string lastName, string classification, string major)
            {
                setFirstName(firstName);
                setLastName(lastName);
                setClassification(classification);
                setMajor(major);
            }
            public string getFirstName() {return this.firstName;}
            public string getLastName() {return this.lastName;}
            public string getClassification() {return this.classification;}
            public string getMajor() {return this.major;}
            public void setFirstName(string firstName){
                if (string.IsNullOrEmpty(firstName)){
                    throw new ArgumentNullException("Empty input");
                }
                else if (!firstName.All(char.IsLetter))
                {
                    throw new ArgumentException("Invalid input charactor");
                }
                this.firstName = firstName;
            }
            public void setLastName(string lastName)
            {
                if (string.IsNullOrEmpty(lastName))
                {
                    throw new ArgumentNullException("Empty input");
                }
                else if (!lastName.All(char.IsLetter))
                {
                    throw new ArgumentException("Invalid input charactor");
                }
                this.lastName = lastName;
            }
            public void setClassification(string classification)
            {
                if (string.IsNullOrEmpty(classification))
                {
                    throw new ArgumentNullException("Empty input");
                }
                this.classification = classification;
            }
            public void setMajor(string major)
            {
                if (string.IsNullOrEmpty(major))
                {
                    throw new ArgumentNullException("Empty input");
                }
                this.major = major;
            }
            public string getFullName() { return this.getFirstName()+' '+this.getFirstName(); }
        }
        static void Main(string[] args)
        {
            try
            {
                Student test = new Student();
                Student student1 = new Student("Jinyu", "Liu");
                Student student2 = new Student("JoJo", "Johnan", "Undergradute", "Computer Science");

                Console.WriteLine("Test, Full Name:"+ test.getFullName());
                Console.WriteLine();
                Console.WriteLine("Student 1, Full Name:" + student1.getFullName()+'\n'
                    + "Classification: " + student1.getClassification()+'\n'
                    + "Major: "+ student1.getMajor());
                Console.WriteLine();
                Console.WriteLine("Student 2, Full Name:" + student2.getFullName() + '\n'
                    + "Classification: " + student2.getClassification() + '\n'
                    + "Major: " + student2.getMajor());
                Console.WriteLine() ;
            }
            catch(ArgumentNullException e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Auto massage: Code has been executed");
            }
            Console.ReadKey();
        }
    }
}

